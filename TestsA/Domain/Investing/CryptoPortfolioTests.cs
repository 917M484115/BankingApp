//using BankingApp.Aids.Random;
//using BankingApp.Data.Investing;
//using BankingApp.Data.Misc;
//using BankingApp.Domain.Common;
//using BankingApp.Domain.Investing;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using BankingApp.Domain.Misc.Repositories;
//using BankingApp.Domain.Investing.Repositories;

//namespace BankingApp.Tests.Domain.Investing
//{
//    public class CryptoPortfolioTests : SealedClassTests<UniqueEntity<CryptoPortfolioData>>
//    {
//        private CryptoPortfolioData data;
//        private ICustomersRepository customersRepo;
//        private CustomerData customerData;
//        private CryptoPortfolio cryptoportfolio;
//        private int itemsCount;
//        private ICryptoPortfolioRepository cryptoportfolioRepo;
//        private ICryptoRepository cryptoRepo;
//        protected override object createObject() => new CryptoPortfolio(data);
//        [TestInitialize]
//        public override void TestInitialize()
//        {
//        }
//        [TestMethod] public void CustomerIDTest() => isProperty(data.CustomerID);
//        [TestMethod]
//        public void CustomerTest()
//        {
//            isNull(cryptoportfolio.Customer);
//            GetRepository.SetServiceProvider(new MockServiceProvider(customersRepo));
//            areEqualProperties(customerData, cryptoportfolio.Customer.Data);
//        }

//        [TestMethod]
//        public void TotalPriceTest()
//        {
//            var expected = 0M;
//            areEqual(expected, cryptoportfolio.TotalPrice);
//            GetRepository.SetServiceProvider(new MockServiceProvider(cryptoRepo));
//            var d = GetRandom.Object<CryptoData>();
//            d.Price = GetRandom.Decimal(0.01M, 999.99M);
//            cryptoRepo.Add(new Crypto(d));
//            expected=d.Price*cryptoportfolio.Units;
//            areEqual(expected, cryptoportfolio.TotalPrice);
//        }
//    }
//}
