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
        public IOrdersRepository CryptoOrdersRepository { get; }
        public IOrderItemsRepository CryptoOrderItemsRepository { get; }
        public ICryptoBasketsRepository CryptoBasketsRepository { get; }
        public ICryptoBasketItemsRepository CryptoBasketItemsRepository { get; }
        public ICryptoPortfolioRepository CryptoPortfolioRepository { get;}
        protected CryptoBasketsBasePage(ICryptoBasketsRepository cbr, ICustomersRepository cr,
            IOrdersRepository or, IOrderItemsRepository coir, ICryptoBasketItemsRepository cbir, ICryptoPortfolioRepository cpr) : base(cbr, "CryptoBaskets")
        {
            CryptoPortfolioRepository = cpr;
            CryptoBasketsRepository = cbr;
            Customers = newItemsList<Customer,CustomerData>(cr);
            CryptoOrdersRepository = or;
            CryptoOrderItemsRepository = coir;
            CryptoBasketItemsRepository = cbir;
        }
        public string CustomerName(string id) => itemName(Customers, id);
        protected internal override Uri pageUrl() => new Uri("/Manager/CryptoBaskets", UriKind.Relative);
        protected internal override CryptoBasket toObject(CryptoBasketView v) => new CryptoBasketViewFactory().Create(v);
        protected internal override CryptoBasketView toView(CryptoBasket o) => new CryptoBasketViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.CustomerID);
            createColumn(x => Item.CustomerName);
            createColumn(x => Item.CustomerCountry);
            createColumn(x => Item.TotalPrice);
        }
        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 => getName<decimal>(h, i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 => getValue<decimal>(h, i),
            _ => base.GetValue(h, i)
        };
        public virtual async Task<IActionResult> OnGetSelectAsync(string id, string sortOrder, string searchString,
        int pageIndex, string fixedFilter, string fixedValue)
        {
            CryptoBasket b = await db.Get(id);
            if (b.Data.To != null) return Redirect(IndexUrl.ToString());
            await db.Close(b);
            await CryptoPortfolioRepository.AddItems(b,b.CustomerID);
            Order o = await CryptoOrdersRepository.GetLatestForUser(User.Identity.Name);
            await CryptoOrderItemsRepository.AddItems(o, b);
            var page = "/Customer/Orders";
            var url = new Uri($"{page}/Index?handler=Index", UriKind.Relative);
            return Redirect(url.ToString());
        }
        
        public override async Task<IActionResult> OnPostDeleteAsync(string id, string sortOrder, string searchString,
            int pageIndex,
            string fixedFilter, string fixedValue)
        {
            CryptoBasket b = await db.Get(id);
            foreach(var i in b.Items)
            {
                await CryptoBasketItemsRepository.Delete(b, i);
            }    
            await CryptoBasketsRepository.Delete(id);
            await deleteObject(id, sortOrder, searchString, pageIndex, fixedFilter, fixedValue).ConfigureAwait(true);
            return Redirect(IndexUrl.ToString());
        }
    }
}
