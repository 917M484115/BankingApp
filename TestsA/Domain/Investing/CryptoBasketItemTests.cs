using BankingApp.Aids.Methods;
using BankingApp.Aids.Random;
using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Investing {
    [TestClass] public class CryptoBasketItemTests: SealedClassTests<UniqueEntity<CryptoBasketItemData>> {

        private CryptoBasketItemData data;
        private CryptoData cryptoData;
        private ICryptoRepository cryptoRepo;
        private CryptoBasketItem cryptobasketItem;

        private class MockProductRepo : MockRepo<Crypto>, ICryptoRepository { }

        protected override object createObject() => new CryptoBasketItem(data);
        [TestInitialize] public override void TestInitialize() {
            data = GetRandom.Object<CryptoBasketItemData>();
            cryptoRepo = MockRepos.CryptoRepo(data.CryptoID, out cryptoData);
            base.TestInitialize();
            cryptobasketItem = obj as CryptoBasketItem;
            GetRepository.SetServiceProvider(new MockServiceProvider(cryptoRepo));
        }

        [TestMethod] public void CryptoBasketIDTest() => isProperty(data.CryptoBasketID);
        [TestMethod] public void CryptoIDTest() => isProperty(data.CryptoID);
        [TestMethod] public void QuantityTest() => isProperty(data.Quantity);
        [TestMethod] public void CryptoTest() {
            areEqualProperties(cryptoData, cryptobasketItem.Crypto.Data);
        }
        [TestMethod] public void CryptoIsNullTest() {
            GetRepository.SetServiceProvider(null);
            isNull((obj as CryptoBasketItem).Crypto);
        }
        [TestMethod] public void UnitPriceTest() => isProperty(cryptoData.Price);
        [TestMethod] public void UnitPriceIsUnspecifiedTest() {
            GetRepository.SetServiceProvider(null);
            areEqual((obj as CryptoBasketItem).UnitPrice, BaseEntity.UnspecifiedDecimal);
        }
        [TestMethod] public void TotalPriceTest() {
            var r = Safe.Run(() => cryptoData.Price * data.Quantity, BaseEntity.UnspecifiedDecimal);
            isProperty(r);
        }
        [TestMethod] public void TotalPriceIsUnspecifiedTest() {
            GetRepository.SetServiceProvider(null);
            areEqual((obj as CryptoBasketItem).TotalPrice, BaseEntity.UnspecifiedDecimal);
        }
        [TestMethod] public void TotalPriceIsNotUnspecifiedTest() {
            data.Quantity = GetRandom.UInt8(10);
            data.CryptoID = GetRandom.String();
            cryptoData.Price = GetRandom.UInt8(10);
            cryptoData.Id = data.CryptoID;
            cryptoRepo.Add(new Crypto(cryptoData));
            obj = createObject();
            areEqual((obj as CryptoBasketItem).TotalPrice, cryptoData.Price * data.Quantity);
        }
    }
}
