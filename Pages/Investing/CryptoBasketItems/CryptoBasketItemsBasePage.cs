using System;
using System.Collections.Generic;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Investing
{
    public abstract class CryptoBasketItemsBasePage<TPage> : ViewPage<TPage,
        ICryptoBasketItemsRepository, CryptoBasketItem, CryptoBasketItemView, CryptoBasketItemData>
        where TPage : PageModel
    {
        protected CryptoBasketItemsBasePage(ICryptoBasketItemsRepository r, ICryptoBasketsRepository b,
            ICryptoRepository p)
            : base(r, "Crypto Basket items")
        {
            Crypto = newItemsList<Crypto, CryptoData>(p);
            CryptoBaskets = newItemsList<CryptoBasket, CryptoBasketData>(b, null, d => new CryptoBasket(d).Name);
        }

        public IEnumerable<SelectListItem> Crypto { get; }
        public IEnumerable<SelectListItem> CryptoBaskets { get; }

        public override string BackToMasterDetailPageUrl => "/Manager/CryptoBaskets/Details" +
                                                            "?handler=Details" +
                                                            $"&id={FixedValue}";

        protected internal override string pageSubtitle()
        {
            return CryptoBasketsName(FixedValue);
        }

        public string CryptoBasketsName(string id)
        {
            return itemName(CryptoBaskets, id);
        }

        public string CryptoName(string id)
        {
            return itemName(Crypto, id);
        }

        protected internal override Uri pageUrl()
        {
            return new("/Manager/CryptoBasketItems", UriKind.Relative);
        }

        protected internal override CryptoBasketItem toObject(CryptoBasketItemView v)
        {
            return new CryptoBasketItemViewFactory().Create(v);
        }

        protected internal override CryptoBasketItemView toView(CryptoBasketItem o)
        {
            return new CryptoBasketItemViewFactory().Create(o);
        }

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
        }

        public override string GetName(IHtmlHelper<TPage> h, int i)
        {
            return i switch
            {
                6 or 8 => getName<decimal>(h, i),
                7 => getName<int>(h, i),
                _ => base.GetName(h, i)
            };
        }

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i)
        {
            return i switch
            {
                6 or 8 => getValue<decimal>(h, i),
                7 => getValue<int>(h, i),
                _ => base.GetValue(h, i)
            };
        }
    }
}