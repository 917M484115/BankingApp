using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Investing
{
    [TestClass]
    public class CryptoBasketItemDataTests : SealedClassTests<NamedEntityData>
    {
        public string CryptoBasketID { get; set; }
        public string CryptoID { get; set; }
        public int Quantity { get; set; }

        [TestMethod] public void CryptoBasketIDTest() => isProperty<string>();
        [TestMethod] public void CryptoIDTest() => isProperty<string>();
        [TestMethod] public void QuantityTest() => isProperty<int>(false);
    }
}
