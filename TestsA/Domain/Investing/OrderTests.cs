using BankingApp.Aids.Random;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Data.Misc;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Misc.Repositories;
using BankingApp.Domain.Investing.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankingApp.Tests.Domain.Investing {
    [TestClass] public class OrderTests : SealedClassTests<UniqueEntity<OrderData>> {
        private OrderData data;
        private ICustomersRepository customersRepo;
        private IOrderItemsRepository itemsRepo;
        private ICryptoRepository cryptoRepo;
        private Order order;
        private int itemsCount;
        private CustomerData customerData;

        protected override object createObject() => new Order(data);
        [TestInitialize] public override void TestInitialize() {
            data = GetRandom.Object<OrderData>();
            customersRepo = MockRepos.Customers(data.CustomerID, out customerData);
            itemsRepo = MockRepos.OrderItemsRepo(data.Id, out itemsCount);
            cryptoRepo = MockRepos.Cryptos();
            base.TestInitialize();
            order = obj as Order;
        }
        [TestMethod] public void CustomerIDTest() => isProperty(data.CustomerID);
        [TestMethod] public void NameTest() 
            => isProperty( $"{order.CustomerID} {order.OrderDate}");
        [TestMethod] public void OrderDateTest() => isProperty(data.OrderDate);
        [TestMethod] public void CustomerTest() {
            isNull(order.Customer);
            GetRepository.SetServiceProvider(new MockServiceProvider(customersRepo));
            areEqualProperties(customerData, order.Customer.Data);
        }
        [TestMethod] public void ItemsTest()
        {
        }
        [TestMethod]
        public void TotalPriceTest()
        {
            var expected = 0M;
            areEqual(expected, order.TotalPrice);
            GetRepository.SetServiceProvider(new MockServiceProvider(itemsRepo, cryptoRepo));
            foreach(var item in order.Items) addCrypto(item.CryptoID);
            foreach (var item in order.Items) expected += item.TotalPrice;
            areEqual(expected, order.TotalPrice);
        }

        private void addCrypto(string id)
        {
            var d = GetRandom.Object<CryptoData>();
            d.Id = id;
            d.Price = GetRandom.Decimal(0.01M, 999999.99M);
            cryptoRepo.Add(new Crypto(d));
        }
    }
}
