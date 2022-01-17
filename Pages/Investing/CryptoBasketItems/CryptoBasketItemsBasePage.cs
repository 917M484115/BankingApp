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
        public IEnumerable<SelectListItem> Crypto { get; }
        public IEnumerable<SelectListItem> CryptoBaskets { get; }
        public ICryptoRepository CryptoRepository { get;}
        public IEnumerable<SelectListItem> BlockChainsRepository { get;}
        protected CryptoBasketItemsBasePage(ICryptoBasketItemsRepository r, ICryptoBasketsRepository b, ICryptoRepository p,IBlockChainsRepository bcr)
           : base(r, "Crypto Basket items")
        {
            CryptoRepository = p;
            BlockChainsRepository = newItemsList<BlockChain,BlockChainData>(bcr);
            Crypto = newItemsList<Crypto, CryptoData>(p);
            CryptoBaskets = newItemsList<CryptoBasket, CryptoBasketData>(b, null, d => new CryptoBasket(d).Name);
        }
        public object GetCryptoByID(string id)=>CryptoRepository.GetById(id);
        public string GetBlockChainByID(string id)
        {
            Crypto c = (Crypto)GetCryptoByID(id);
            return c.BlockChainID;
        }
        protected internal override string pageSubtitle() => CryptoBasketsName(FixedValue);
        public string CryptoBasketsName(string id) => itemName(CryptoBaskets, id);
        public string CryptoName(string id) => itemName(Crypto, id);
        public string BlockChainName(string id) => itemName(BlockChainsRepository,GetBlockChainByID(id));
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
            createColumn(x => Item.UnitPrice);
            createColumn(x => Item.Quantity);
            createColumn(x => Item.TotalPrice);
        }
        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            5 or 7 => getName<decimal>(h, i),
            6 => getName<int>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            5 or 7 => getValue<decimal>(h, i),
            6 => getValue<int>(h, i),
            _ => base.GetValue(h, i)
        };
        public override string BackToMasterDetailPageUrl => $"/Manager/CryptoBaskets/Details" +
                       "?handler=Details" +
                       $"&id={FixedValue}";
    }
}
