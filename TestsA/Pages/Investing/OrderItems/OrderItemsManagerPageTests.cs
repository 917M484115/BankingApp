using BankingApp.Pages.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages.Investing
{
    [TestClass]
    public class OrderItemsManagerPageTests : AuthorizedPageTests<OrderItemsManagerPage, OrderItemsBasePage<OrderItemsManagerPage>>
    {
        protected override object createObject()
            => new OrderItemsManagerPage(MockRepos.OrderItems(), MockRepos.Orders(), MockRepos.Cryptos());

      
        protected override string expectedUrl => "/Manager/OrderItems";

       
        protected override List<string> expectedIndexPageColumns
            => new() {
                "OrderType",
                "Id",
                "OrderID",
                "CryptoID",
                "CryptoName",
                "UnitPrice",
                "Units",
                "TotalPrice",
                "OrderTime"
            };
        

       
    }
}
