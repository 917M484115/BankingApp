using BankingApp.Data.Investing;
using BankingApp.Data.Misc;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingApp.Pages.Investing
{
    public abstract class CryptoBasketsBasePage<TPage> :
        ViewPage<TPage, ICryptoBasketsRepository, CryptoBasket, CryptoBasketView, CryptoBasketData>
        where TPage : PageModel
    {
        public IEnumerable<SelectListItem> Customers { get; }
        public IOrdersRepository CryptoOrders { get; }
        public IOrderItemsRepository CryptoOrderItems { get; }
        protected CryptoBasketsBasePage(ICryptoBasketsRepository cbr, ICustomersRepository cr,
            IOrdersRepository or, IOrderItemsRepository coir) : base(cbr, "CryptoBaskets")
        {
            Customers = newItemsList<Customer,CustomerData>(cr);
            CryptoOrders = or;
            CryptoOrderItems = coir;
        }
        public string CustomerName(string id) => itemName(Customers, id);
        protected internal override Uri pageUrl() => new Uri("/Investing/CryptoBaskets", UriKind.Relative);
        protected internal override CryptoBasket toObject(CryptoBasketView v) => new CryptoBasketViewFactory().Create(v);
        protected internal override CryptoBasketView toView(CryptoBasket o) => new CryptoBasketViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.CustomerID);
            createColumn(x => Item.CustomerName);
            createColumn(x => Item.CustomerCountry);
            createColumn(x => Item.TotalPrice);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 => getName<decimal>(h, i),
            5 or 6 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 => getValue<decimal>(h, i),
            5 or 6 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };
        public virtual async Task<IActionResult> OnGetSelectAsync(string id, string sortOrder, string searchString,
        int pageIndex, string fixedFilter, string fixedValue)
        {
            CryptoBasket b = await db.Get(id);
            if (b.Data.To != null) return Redirect(IndexUrl.ToString());
            await db.Close(b);
            Order o = await CryptoOrders.GetLatestForUser(User.Identity.Name);
            await CryptoOrderItems.AddItems(o, b);

            var page = "/Customer/Orders";
            var url = new Uri($"{page}/Index?handler=Index", UriKind.Relative);
            return Redirect(url.ToString());
        }
    }
}
