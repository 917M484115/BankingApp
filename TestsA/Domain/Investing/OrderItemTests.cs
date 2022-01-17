using BankingApp.Aids.Random;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Investing
{
    [TestClass]
    public class OrderItemTests : SealedClassTests<UniqueEntity<OrderItemData>>
    {
        private OrderItemData data;
        private ICryptoRepository cryptoRepo;
        private CryptoData cryptoData;
        private OrderItem orderItem;

        protected override object createObject() => new OrderItem(data);
        [TestInitialize]
        public override void TestInitialize()
        {
            data = GetRandom.Object<OrderItemData>();
            cryptoRepo = MockRepos.CryptoRepo(data.CryptoID, out cryptoData);
            cryptoData.Price = GetRandom.Decimal(0.01M, 999999.99M);
            base.TestInitialize();
            orderItem = obj as OrderItem;
        }
        [TestMethod] public void CryptoIDTest() => isProperty(data.CryptoID);
        [TestMethod]
        public void UnitPriceTest()
        {
            isProperty(decimal.MaxValue);
            GetRepository.SetServiceProvider(new MockServiceProvider(cryptoRepo));
            areEqual(cryptoData.Price, orderItem.UnitPrice);
        }
        [TestMethod] public void OrderTimeTest() => isProperty(data.OrderTime);
        [TestMethod] public void UnitsTest() => isProperty(data.Units);
        [TestMethod] public void OrderIDTest() => isProperty(data.OrderID);
        [TestMethod]
        public void CryptoTest()
        {
            isNull(orderItem.Crypto);
            GetRepository.SetServiceProvider(new MockServiceProvider(cryptoRepo));
            areEqualProperties(cryptoData, orderItem.Crypto.Data);
        }
        [TestMethod]
        public void TotalPriceTest()
        {
            var expected = decimal.MaxValue;
            isProperty(expected);
            GetRepository.SetServiceProvider(new MockServiceProvider(cryptoRepo));
            expected = data.Units * cryptoData.Price;
            areEqual(expected, orderItem.TotalPrice);
        }
    }
}
