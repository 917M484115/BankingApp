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
    public class OrdersManagerPageTests : AuthorizedPageTests<OrdersManagerPage, OrdersBasePage<OrdersManagerPage>>
    {
        protected override object createObject()
            => new OrdersManagerPage(MockRepos.Orders(), MockRepos.Customers());

        //    [Authorize]
        //public class OrdersPageTests :ViewPage<OrdersPageTests, IOrdersRepository, Order, OrderView, OrderData> {
        //    public IEnumerable<SelectListItem> Buyers { get; }

        //    public OrdersPageTests(IOrdersRepository r, IBuyersRepository b) : base(r, "Orders") {
        //        Buyers = newItemsList<Buyer, BuyerData>(b);
        //    }

        //    public string BuyerName(string id) => itemName(Buyers, id);
        protected override string expectedUrl => "/Manager/Orders";

        //    protected internal override Order toObject(OrderView v) => new OrderViewFactory().Create(v);
        //    protected internal override OrderView toView(Order o) => new OrderViewFactory().Create(o);
        protected override List<string> expectedIndexPageColumns
            => new() {
                "Id",

                "CustomerName",

                "TotalPrice",
                "OrderDate",
            };
    }
}
