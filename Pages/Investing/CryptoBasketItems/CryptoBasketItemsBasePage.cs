using BankingApp.Aids.Constants;
using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankingApp.Pages.Investing
{
    public abstract class CryptoBasketItemsBasePage<TPage> : ViewPage<TPage,
        ICryptoBasketItemsRepository, CryptoBasketItem, CryptoBasketItemView, CryptoBasketItemData>
        where TPage : PageModel
    {
        public IEnumerable<SelectListItem> Crypto { get; }
        public IEnumerable<SelectListItem> BlockChain { get; }
        public IEnumerable<SelectListItem> Price { get; }
        public IEnumerable<SelectListItem> Ticker { get; }
        public IEnumerable<SelectListItem> CryptoBaskets { get; }
        protected CryptoBasketItemsBasePage(ICryptoBasketItemsRepository r, ICryptoBasketsRepository b, ICryptoRepository p)
           : base(r, "Crypto Basket items")
        {
            Crypto = newItemsList<Crypto, CryptoData>(p);
            BlockChain=newBlockChainsList<Crypto, CryptoData>(p);
            Price=newPriceList<Crypto, CryptoData>(p);
            Ticker=newTickerList<Crypto, CryptoData>(p);
            CryptoBaskets = newItemsList<CryptoBasket, CryptoBasketData>(b, null, d => new CryptoBasket(d).Name);
        }
        protected internal override string pageSubtitle() => CryptoBasketsName(FixedValue);
        public string CryptoBasketsName(string id) => itemName(CryptoBaskets, id);
        public string CryptoName(string id) => itemName(Crypto, id);
        public string BlockChainName(string id) => itemName(BlockChain, id);
        public string CryptoPrice(string id) => itemName(Price, id);
        public string TickerName(string id) => itemName(Ticker, id);
        protected internal static IEnumerable<SelectListItem> newBlockChainsList<TTDomain, TTData>(
            IRepository<TTDomain> r,
            Func<TTDomain, bool> condition = null,
            Func<TTData, string> getName = null)
            where TTDomain : IEntity<TTData>
            where TTData : UniqueEntityData, new()
        {
            Func<TTData, string> name = d => (getName is null) ? (d as CryptoData)?.Blockchain : getName(d);
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
        protected internal static IEnumerable<SelectListItem> newTickerList<TTDomain, TTData>(
            IRepository<TTDomain> r,
            Func<TTDomain, bool> condition = null,
            Func<TTData, string> getName = null)
            where TTDomain : IEntity<TTData>
            where TTData : UniqueEntityData, new()
        {
            Func<TTData, string> name = d => (getName is null) ? (d as CryptoData)?.Ticker : getName(d);
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
        protected internal static IEnumerable<SelectListItem> newPriceList<TTDomain, TTData>(
            IRepository<TTDomain> r,
            Func<TTDomain, bool> condition = null,
            Func<TTData, string> getName = null)
            where TTDomain : IEntity<TTData>
            where TTData : UniqueEntityData, new()
        {
            Func<TTData, string> name = d => (getName is null) ? (d as CryptoData).Price.ToString() : getName(d);
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
