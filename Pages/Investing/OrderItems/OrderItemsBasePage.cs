using BankingApp.Data.Investing;
using BankingApp.Data.Misc;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BankingApp.Domain.Misc.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingApp.Pages.Investing
{
    public abstract class OrderItemsBasePage<TPage>:ViewPage<TPage,IOrderItemsRepository, OrderItem, OrderItemView, OrderItemData>
        where TPage : PageModel
    {
        public IEnumerable<SelectListItem> Orders { get; }
        public IEnumerable<SelectListItem> Crypto { get; }
        protected OrderItemsBasePage(IOrderItemsRepository r, IOrdersRepository o, ICryptoRepository p)
            : base(r, "Order items")
        {
            Orders = newItemsList<Order, OrderData>(o, null, d => new Order(d).Name);
            Crypto = newItemsList<Crypto, CryptoData>(p);
        }
        public override string BackToMasterDetailPageUrl => $"/Manager/Orders/Details" +
                       "?handler=Details" +
                       $"&id={FixedValue}";
        protected internal override string pageSubtitle() => OrderName(FixedValue);
        public string OrderName(string id) => itemName(Orders, id);
        public string CryptoName(string id) => itemName(Crypto, id);
        protected internal override Uri pageUrl() => new Uri("/Manager/OrderItems", UriKind.Relative);
        protected internal override OrderItem toObject(OrderItemView v) => new OrderItemViewFactory().Create(v);
        protected internal override OrderItemView toView(OrderItem o) => new OrderItemViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.OrderID);
            createColumn(x => Item.CryptoID);
            createColumn(x => Item.CryptoName);
            createColumn(x => Item.UnitPrice);
            createColumn(x => Item.Units);
            createColumn(x => Item.TotalPrice);
            createColumn(x => Item.From);
            createColumn(x => Item.To);
        }
        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 or 6 => getName<decimal>(h, i),
            5 => getName<int>(h, i),
            7 or 8 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 or 6 => getValue<decimal>(h, i),
            5 => getValue<int>(h, i),
            7 or 8 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
