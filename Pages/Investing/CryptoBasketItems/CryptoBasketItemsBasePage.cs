using BankingApp.Aids.Constants;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace BankingApp.Pages.Investing
{
    public abstract class CryptoBasketItemsBasePage<TPage> : ViewPage<TPage,
        ICryptoBasketItemsRepository, CryptoBasketItem, CryptoBasketItemView, CryptoBasketItemData>
        where TPage : PageModel
    {
        public IEnumerable<SelectListItem> Crypto { get; }
        public IEnumerable<SelectListItem> CryptoBaskets { get; }
        protected CryptoBasketItemsBasePage(ICryptoBasketItemsRepository r, ICryptoBasketsRepository b, ICryptoRepository p)
           : base(r, "Crypto Basket items")
        {
            Crypto = newItemsList<Crypto, CryptoData>(p);
            CryptoBaskets = newItemsList<CryptoBasket, CryptoBasketData>(b, null, d => new CryptoBasket(d).Name);
        }
        protected internal override string pageSubtitle() => CryptoBasketsName(FixedValue);
        public string CryptoBasketsName(string id) => itemName(CryptoBaskets, id);
        public string CryptoName(string id) => itemName(Crypto, id);
        protected internal static string tickerName(IEnumerable<SelectListItem> list, string id)
        {
            if (list is null) return Word.Unspecified;

            foreach (var m in list)
                if (m.Value == id)
                    return m.Text;

            return Word.Unspecified;
        }
        protected internal override Uri pageUrl() => new Uri("/Manager/CryptoBasketItems", UriKind.Relative);
        protected internal override CryptoBasketItem toObject(CryptoBasketItemView v) => new CryptoBasketItemViewFactory().Create(v);
        protected internal override CryptoBasketItemView toView(CryptoBasketItem o) => new CryptoBasketItemViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.CryptoBasketID);
            createColumn(x => Item.CryptoID);
            createColumn(x => Item.CryptoName);
            createColumn(x => Item.Ticker);
            createColumn(x => Item.BlockChain);
            createColumn(x => Item.UnitPrice);
            createColumn(x => Item.Quantity);
            createColumn(x => Item.TotalPrice);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            6 or 8 => getName<decimal>(h, i),
            7 => getName<int>(h, i),
            9 or 10 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            6 or 8 => getValue<decimal>(h, i),
            7 => getValue<int>(h, i),
            9 or 10 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };
        public override string BackToMasterDetailPageUrl => $"/Manager/CryptoBaskets/Details" +
                       "?handler=Details" +
                       $"&id={FixedValue}";
    }
}
