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
    public sealed class OrderItemsClientPage: OrderItemsBasePage<OrderItemsClientPage>
    {
        public OrderItemsClientPage(IOrderItemsRepository r, IOrdersRepository o, ICryptoRepository p)
            : base(r, o, p) { }
        public override string BackToMasterDetailPageUrl => $"/Customer/Orders/Details" +
                      "?handler=Details" +
                      $"&id={FixedValue}";
        protected internal override Uri pageUrl() => new Uri("/Customer/OrderItems", UriKind.Relative);
        protected override void createTableColumns()
        {
            createColumn(x => Item.OrderType);
            createColumn(x => Item.CryptoName);
            createColumn(x => Item.UnitPrice);
            createColumn(x => Item.Units);
            createColumn(x => Item.TotalPrice);
            createColumn(x => Item.OrderTime);
        }
        public override string GetName(IHtmlHelper<OrderItemsClientPage> h, int i) => i switch
        {
            2 or 4 => getName<decimal>(h, i),
            3 => getName<int>(h, i),
            5 => getName<DateTime>(h,i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<OrderItemsClientPage> h, int i) => i switch
        {
            2 or 4 => getValue<decimal>(h, i),
            3 => getValue<int>(h, i),
            5 => getValue<DateTime>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
