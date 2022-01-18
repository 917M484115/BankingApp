using BankingApp.Pages.Investing;
using BankingApp.Tests;
using BankingApp.Tests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages.Investing
{
    [TestClass]
    public class OrdersClientPageTests : AuthorizedPageTests<OrdersClientPage, OrdersBasePage<OrdersClientPage>>
    {
        protected override object createObject()
            => new OrdersClientPage(MockRepos.Orders(), MockRepos.Customers());
        //    [Authorize]
        //public sealed class OrdersClientPageTests :OrdersBasePageTests<OrdersClientPageTests> {
        //    public OrdersClientPageTests(IOrdersRepository r, IBuyersRepository b) : base(r, b) {}
        protected override string expectedUrl => "/Customer/Orders";
        [TestMethod] public void OnGetIndexAsyncTest() => notTested();
        [TestMethod] public void OnGetDetailsAsyncTest() => notTested();

        protected override List<string> expectedIndexPageColumns
            => new() { "CustomerName", "TotalPrice", "OrderDate", "Closed" };


        //    public override async Task OnGetIndexAsync(string sortOrder,
        //       string id, string currentFilter, string searchString, int? pageIndex,
        //       string fixedFilter, string fixedValue) {
        //        SelectedId = id;
        //        fixedFilter = GetMember.Name<OrderData>(x => x.BuyerId);
        //        fixedValue = User.Identity.Name;
        //        await getList(sortOrder, currentFilter, searchString, pageIndex,
        //            fixedFilter, fixedValue).ConfigureAwait(true);
        //    }
        //    public override async Task<IActionResult> OnGetDetailsAsync(string id, string sortOrder, string searchString,
        //        int pageIndex,
        //        string fixedFilter, string fixedValue) {
        //        var name = GetMember.Name<OrderItemData>(x => x.OrderId);
        //        var page = "/Client/OrderItems";
        //        var url = new Uri($"{page}/Index?handler=Index&fixedFilter={name}&fixedValue={id}",
        //            UriKind.Relative);

        //        await Task.CompletedTask.ConfigureAwait(false);

        //        return Redirect(url.ToString());
        //    }
    }
}
