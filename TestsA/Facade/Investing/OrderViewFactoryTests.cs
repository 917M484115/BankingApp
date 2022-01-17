using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using BankingApp.Tests;
using BankingApp.Tests.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Investing
{
    [TestClass]public class OrderViewFactoryTests : FactoryBaseTests<OrderViewFactory, OrderData, Order, OrderView>
    {
        protected override string[] excludeProperties => new string[] { "BuyerName", "BuyerAddress", "TotalPrice", "Closed" };
        protected override void doBeforeCreateViewTest(OrderData d)
        {
            var r = MockRepos.Customers(d.CustomerID, out _);
            GetRepository.SetServiceProvider(new MockServiceProvider(r));
        }
        protected override void doAfterCreateViewTest(Order o, OrderView v)
        {
            areEqual(o.Customer.Name, v.CustomerName);
            
            areEqual(o.Data.To is not null, v.Closed);
            areEqual(o.TotalPrice, v.TotalPrice);
        }
        protected override Order createObject(OrderData d) => new(d);
    }
}
