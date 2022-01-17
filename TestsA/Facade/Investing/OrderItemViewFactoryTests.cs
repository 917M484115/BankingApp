using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Investing
{
    [TestClass]
    public class OrderItemViewFactoryTests : FactoryBaseTests<OrderItemViewFactory, OrderItemData, OrderItem, OrderItemView>
    {
        protected override string[] excludeProperties => new string[] { "ProductName", "PictureUri", "UnitPrice", "TotalPrice" };
        protected override void doBeforeCreateViewTest(OrderItemData d)
        {
            var r = MockRepos.OrderItemsRepo(d.CryptoID, out _);
            GetRepository.SetServiceProvider(new MockServiceProvider(r));
        }
        protected override void doAfterCreateViewTest(OrderItem o, OrderItemView v)
        {
            areEqual(o.Crypto.ToString(), v.CryptoName);
            areEqual(o.UnitPrice, v.UnitPrice);
            areEqual(o.TotalPrice, v.TotalPrice);
        }
        protected override OrderItem createObject(OrderItemData d) => new(d);
    }
}
