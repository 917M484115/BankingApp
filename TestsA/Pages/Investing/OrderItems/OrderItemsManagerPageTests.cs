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
    public class OrderItemsPageTests : AuthorizedPageTests<OrderItemsManagerPage, OrderItemsBasePage<OrderItemsManagerPage>>
    {
        protected override object createObject()
            => new OrderItemsManagerPage(MockRepos.OrderItems(), MockRepos.Orders(), MockRepos.Cryptos());

      
        protected override string expectedUrl => "/Shop/OrderItems";

       
        protected override List<string> expectedIndexPageColumns
            => new() { "Id", "OrderId", "ProductId", "ProductName", "PictureUri", "UnitPrice", "Units", "TotalPrice", "From", "To" };
        protected override void validateValue(string actual, string expected)
        {
            if (expected == "PictureUri")
                areEqual("<img src=\"\" alt=\"uu\" style=\"height: 75px\"/>", actual);
            else base.validateValue(actual, expected);
        }

       
    }
}
