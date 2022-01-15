using BankingApp.Aids.Constants;
using BankingApp.Data.Misc;
using BankingApp.Domain.Misc.Repositories;
using BankingApp.Facade.Misc;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

namespace BankingApp.Pages.Misc
{
    public sealed class CustomersClientPage : CustomersBasePage<CustomersClientPage>
    {
        public CustomersClientPage(ICustomersRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new Uri("/Customer/Customers", UriKind.Relative);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Name);
            createColumn(x => Item.Age);
            createColumn(x => Item.Country);
        }
        public override async Task OnGetIndexAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            fixedFilter = nameof(CustomerData.Id);
            fixedValue = User?.Identity?.Name ?? Word.Unspecified;
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue).ConfigureAwait(true);
        }
        public override string GetName(IHtmlHelper<CustomersClientPage> h, int i) => i switch
        {
            1 => getName<int>(h,i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<CustomersClientPage> h, int i) => i switch
        {
            1 => getValue<int>(h, i),
            _ => base.GetValue(h, i)
        };
        public override IActionResult OnGetCreate(
            string sortOrder, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue, int? switchOfCreate)
        {
            Item = new CustomerView { Id = User?.Identity?.Name ?? Guid.NewGuid().ToString() };
            return base.OnGetCreate(sortOrder, searchString, pageIndex, fixedFilter, fixedValue, switchOfCreate);
        }
    }
}
