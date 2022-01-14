using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Investing
{
    [TestClass]
    public class CryptoDataTests : SealedClassTests<NamedEntityData> 
    {
        [TestMethod] public void BlockChainTest() => isProperty<string>();
        [TestMethod] public void PriceTest() => isProperty<decimal>(false);
        [TestMethod] public void TickerTest() => isProperty<string>();
    }
}
