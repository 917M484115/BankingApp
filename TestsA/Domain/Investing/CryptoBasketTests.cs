using BankingApp.Aids.Random;
using BankingApp.Data.Investing;
using BankingApp.Data.Misc;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingApp.Domain.Misc.Repositories;
using BankingApp.Domain.Investing.Repositories;
namespace BankingApp.Tests.Domain.Investing
{
    [TestClass]
    public class CryptoBasketTests : SealedClassTests<UniqueEntity<CryptoBasketData>>
    {
        private CryptoBasketData data;
        private ICustomersRepository customersRepo;
        private CustomerData customerData;
        private CryptoBasket cryptobasket;
        private int itemsCount;
        private ICryptoBasketItemsRepository itemsRepo;
        private ICryptoRepository cryptoRepo;

        protected override object createObject() => new CryptoBasket(data);
        [TestInitialize] public override void TestInitialize() { 
            data = GetRandom.Object<CryptoBasketData>();
            customersRepo = MockRepos.Customers(data.CustomerID, out customerData);
            itemsRepo = MockRepos.CryptoBasketItemsRepo(data.Id, out itemsCount);
            cryptoRepo = MockRepos.Cryptos();
            base.TestInitialize();
            cryptobasket = obj as CryptoBasket;
        }
        [TestMethod] public void CustomerIDTest() => isProperty(data.CustomerID);
        [TestMethod] public void CustomerTest() {
            isNull(cryptobasket.Customer);
            GetRepository.SetServiceProvider(new MockServiceProvider(customersRepo));
            areEqualProperties(customerData, cryptobasket.Customer.Data);
        }
        [TestMethod] public void ItemsTest() {
            areEqual(0, cryptobasket.Items.Count);
            GetRepository.SetServiceProvider(new MockServiceProvider(itemsRepo));
            areEqual(itemsCount, cryptobasket.Items.Count);
            foreach (var item in cryptobasket.Items)
            {
                areEqual(item.CryptoBasketID, cryptobasket.Id);
            }
        }
        [TestMethod] public void NameTest() 
            => isProperty($"{cryptobasket.CustomerID} {cryptobasket.ValidFrom}");

        [TestMethod] public void TotalPriceTest() {
            var expected = 0M;
            areEqual(expected, cryptobasket.TotalPrice);
            GetRepository.SetServiceProvider(new MockServiceProvider(itemsRepo, cryptoRepo));
            foreach (var item in cryptobasket.Items) addCrypto(item.CryptoID);
            foreach (var item in cryptobasket.Items) expected += item.TotalPrice;
            areEqual(expected, cryptobasket.TotalPrice);
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
