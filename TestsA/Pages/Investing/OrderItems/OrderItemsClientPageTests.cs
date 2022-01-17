using BankingApp.Pages.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages.Investing.OrderItems
{
    [TestClass]
    public class OrderItemsClientPageTests
       : AuthorizedPageTests<OrderItemsClientPage, OrderItemsBasePage<OrderItemsClientPage>>
    {
        protected override object createObject()
            => new OrderItemsClientPage(MockRepos.OrderItems(), MockRepos.Orders(), MockRepos.Cryptos());
        [TestMethod] public void BackToMasterDetailPageUrlTest() => notTested();

        //        [Authorize]
        //public sealed class OrderItemsClientPageTests :OrderItemsBasePageTests<OrderItemsClientPageTests> {
        //    public OrderItemsClientPageTests(IOrderItemsRepository r, IOrdersRepository o, IProductsRepository p) 
        //        : base(r, o, p) { }
        //    public override string BackToMasterDetailPageUrl => $"/Client/Orders/Details" +
        //                   "?handler=Details" +
        //                   $"&id={FixedValue}";
        protected override string expectedUrl => "/Client/OrderItems";
        protected override List<string> expectedIndexPageColumns
            => new() { "ProductName", "PictureUri", "UnitPrice", "Units", "TotalPrice" };
        protected override void validateValue(string actual, string expected)
        {
            if (expected == "PictureUri")
                areEqual("<img src=\"\" alt=\"uu\" style=\"height: 75px\"/>", actual);
            else base.validateValue(actual, expected);
        }

        //    public override string GetName(IHtmlHelper<OrderItemsClientPageTests> h, int i) => i switch {
        //        2 or 4 => getName<decimal>(h, i),
        //        3 => getName<int>(h, i),
        //        _ => base.GetName(h, i)
        //    };
        //    public override IHtmlContent GetValue(IHtmlHelper<OrderItemsClientPageTests> h, int i) => i switch {
        //        1 => h.DisplayImageFor(Item.PictureUri),
        //        2 or 4 => getValue<decimal>(h, i),
        //        3 => getValue<int>(h, i),
        //        _ => base.GetValue(h, i)
        //    };
    }
}
