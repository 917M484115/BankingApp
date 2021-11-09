using System;
using System.Collections.Generic;
using System.Linq;
using BankingApp.Aids.Constants;
using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using BankingApp.Facade.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Common {

    public abstract class TitledPage<TRepository, TDomain, TView, TData> :
        PagedPage<TRepository, TDomain, TView, TData>
        where TRepository : class, ICrudMethods<TDomain>, ISorting, IFiltering, IPaging
        where TView : PeriodView
    {

        protected internal TitledPage(TRepository r, string title) : base(r) => PageTitle = title;

        public string PageTitle { get; }

        public string PageSubTitle => FixedValue is null
        ? string.Empty
        : $"{pageSubtitle()}";

        protected internal virtual string pageSubtitle() => string.Empty;

        public Uri PageUrl => pageUrl();
        public Uri CreateUrl => createUrl();
        public virtual string BackToMasterDetailPageUrl => string.Empty;
        protected internal Uri createUrl()
            => new Uri($"{PageUrl}/Create" +
                       "?handler=Create" +
                       $"&pageIndex={PageIndex}" +
                       $"&sortOrder={SortOrder}" +
                       $"&searchString={SearchString}" +
                       $"&fixedFilter={FixedFilter}" +
                       $"&fixedValue={FixedValue}", UriKind.Relative);

        protected internal abstract Uri pageUrl();

        public Uri IndexUrl => indexUrl();

        protected internal Uri indexUrl() =>
            new Uri($"{PageUrl}/Index?handler=Index&fixedFilter={FixedFilter}&fixedValue={FixedValue}", UriKind.Relative);

        protected internal static IEnumerable<SelectListItem> newItemsList<TTDomain, TTData>(
            IRepository<TTDomain> r,
            Func<TTDomain, bool> condition = null,
            Func<TTData, string> getName = null)
            where TTDomain : IEntity<TTData>
            where TTData : UniqueEntityData, new()
        {
            Func<TTData, string> name = d => (getName is null) ? (d as IUniqueNamedData)?.Name : getName(d);
            var items = r?.Get().GetAwaiter().GetResult();
            var l = items is null
                ? new List<SelectListItem>()
                : condition is null ?
                    items
                    .Select(m => new SelectListItem(name(m.Data), m.Data.Id))
                    .ToList() :
                    items
                    .Where(condition)
                    .Select(m => new SelectListItem(name(m.Data), m.Data.Id))
                    .ToList();
            l.Insert(0, new SelectListItem(Word.Unspecified, null));
            return l;
        }

        protected internal static string itemName(IEnumerable<SelectListItem> list, string id)
        {
            if (list is null) return Word.Unspecified;

            foreach (var m in list)
                if (m.Value == id)
                    return m.Text;

            return Word.Unspecified;
        }

        public virtual bool IsMasterDetail() => PageSubTitle != string.Empty;

    }

}
