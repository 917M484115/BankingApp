using BankingApp.Aids.Reflection;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;
namespace BankingApp.Pages.Investing
{
    public sealed class CryptoBasketsClientPage : CryptoBasketsBasePage<CryptoBasketsClientPage>
    {
        public CryptoBasketsClientPage(ICryptoBasketsRepository cbr, ICustomersRepository cr,
            IOrdersRepository or, IOrderItemsRepository coir, ICryptoBasketItemsRepository cbir, ICryptoPortfolioRepository cpr) : base(cbr, cr, or, coir, cbir, cpr) { }
        protected internal override Uri pageUrl() => new Uri("/Customer/CryptoBaskets", UriKind.Relative);
        public override async Task OnGetIndexAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            fixedFilter = GetMember.Name<CryptoBasketData>(x => x.CustomerID);
            fixedValue = User.Identity.Name;
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue).ConfigureAwait(true);
        }
        public override async Task<IActionResult> OnGetDetailsAsync(string id, string sortOrder, string searchString,
          int pageIndex,
          string fixedFilter, string fixedValue)
        {
            var name = GetMember.Name<CryptoBasketItemData>(x => x.CryptoBasketID);
            var page = "/Customer/CryptoBasketItems";
            var url = new Uri($"{page}/Index?handler=Index&fixedFilter={name}&fixedValue={id}",
                UriKind.Relative);

            await Task.CompletedTask.ConfigureAwait(false);

            return Redirect(url.ToString());
        }
        protected override void createTableColumns()
        {
            createColumn(x => Item.CustomerName);
            createColumn(x => Item.CustomerCountry);
            createColumn(x => Item.TotalPrice);
            createColumn(x => Item.Closed);
        }
        public override string GetName(IHtmlHelper<CryptoBasketsClientPage> h, int i) => i switch
        {
            2 => getName<decimal>(h, i),
            3 => getName<bool>(h, i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<CryptoBasketsClientPage> h, int i) => i switch
        {
            2 => getValue<decimal>(h, i),
            3 => getValue<bool>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
