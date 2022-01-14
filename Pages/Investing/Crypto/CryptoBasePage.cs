using BankingApp.Pages.Common;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using BankingApp.Data.Investing;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankingApp.Domain.Investing.Repositories;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankingApp.Pages.Investing
{
    public abstract class CryptoBasePage<TPage> :
        ViewPage<TPage, ICryptoRepository, Crypto, CryptoView, CryptoData>
        where TPage : PageModel
    {
        public ICryptoBasketsRepository CryptoBaskets { get;}
        public ICryptoBasketItemsRepository CryptoBasketItems { get; }

        protected CryptoBasePage(ICryptoRepository r,
            ICryptoBasketsRepository cbr, ICryptoBasketItemsRepository cir) 
            : base(r, "Crypto")
        {
            CryptoBaskets = cbr;
            CryptoBasketItems = cir;
        }
        protected internal override Uri pageUrl() => new Uri("/Manager/Crypto", UriKind.Relative);
        protected internal override Crypto toObject(CryptoView v) => new CryptoViewFactory().Create(v);
        protected internal override CryptoView toView(Crypto o) => new CryptoViewFactory().Create(o);

        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Ticker);
            createColumn(x => Item.Blockchain);
            createColumn(x => Item.Price);
        }
        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 => getName<decimal>(h, i),
            5 or 6 => getName<DateTime?>(h, i),
            _ => base.getName<string>(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 => getValue<decimal>(h, i),
            5 or 6 => getValue<DateTime?>(h, i),
            _ => base.getValue<string>(h, i)
        };
        public virtual async Task<IActionResult> OnGetSelectAsync(string id, string sortOrder, string searchString,
        int pageIndex, string fixedFilter, string fixedValue)
        {

            Crypto c = await db.Get(id);
            CryptoBasket b = await CryptoBaskets.GetLatestForUser(User.Identity.Name);
            CryptoBasketItem i = await CryptoBasketItems.Add(b,c);
            var page = "/Customer/CryptoBasketItems";
            var url = new Uri($"{page}/Edit?handler=Edit" +
                $"&id={i.Id}" +
                $"&fixedFilter={nameof(i.CryptoBasketID)}" +
                $"&fixedValue={b.Id}", UriKind.Relative);
            return Redirect(url.ToString());
        }
    }
}
