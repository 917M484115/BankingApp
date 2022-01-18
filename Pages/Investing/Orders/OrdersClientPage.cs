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
using BankingApp.Aids.Reflection;

namespace BankingApp.Pages.Investing
{
    public sealed class OrdersClientPage :OrdersBasePage<OrdersClientPage>
    {
        public OrdersClientPage(IOrdersRepository r, ICustomersRepository b,IOrderItemsRepository oir) : base(r, b,oir) { }
        protected internal override Uri pageUrl() => new Uri("/Customer/Orders", UriKind.Relative);
        protected override void createTableColumns()
        {
            createColumn(x => Item.CustomerName);
            createColumn(x => Item.TotalPrice);
            createColumn(x => Item.OrderDate);
            createColumn(x => Item.Closed);
        }
        public override string GetName(IHtmlHelper<OrdersClientPage> h, int i) => i switch
        {
            1 => getName<decimal>(h, i),
            2 => getName<DateTime>(h, i),
            3 => getName<bool>(h, i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<OrdersClientPage> h, int i) => i switch
        {
            1 => getValue<decimal>(h, i),
            2 => getValue<DateTime>(h, i),
            3 => getValue<bool>(h, i),
            _ => base.GetValue(h, i)
        };
        public override async Task OnGetIndexAsync(string sortOrder,
           string id, string currentFilter, string searchString, int? pageIndex,
           string fixedFilter, string fixedValue)
        {
            SelectedId = id;
            fixedFilter = GetMember.Name<OrderData>(x => x.CustomerID);
            fixedValue = User.Identity.Name;
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue).ConfigureAwait(true);
        }
        public override async Task<IActionResult> OnGetDetailsAsync(string id, string sortOrder, string searchString,
            int pageIndex,
            string fixedFilter, string fixedValue)
        {
            var name = GetMember.Name<OrderItemData>(x => x.OrderID);
            var page = "/Customer/OrderItems";
            var url = new Uri($"{page}/Index?handler=Index&fixedFilter={name}&fixedValue={id}",
                UriKind.Relative);

            await Task.CompletedTask.ConfigureAwait(false);

            return Redirect(url.ToString());
        }
    }
}
