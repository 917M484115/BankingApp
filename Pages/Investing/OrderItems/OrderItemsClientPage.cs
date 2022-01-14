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
            createColumn(x => Item.CryptoName);
            createColumn(x => Item.UnitPrice);
            createColumn(x => Item.Units);
            createColumn(x => Item.TotalPrice);
        }
        public override string GetName(IHtmlHelper<OrderItemsClientPage> h, int i) => i switch
        {
            1 or 3 => getName<decimal>(h, i),
            2 => getName<int>(h, i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<OrderItemsClientPage> h, int i) => i switch
        {
            1 or 3 => getValue<decimal>(h, i),
            2 => getValue<int>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
