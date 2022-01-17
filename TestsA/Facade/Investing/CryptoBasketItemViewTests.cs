using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Investing
{
    [TestClass]
    public class CryptoBasketItemViewTests : SealedClassTests<UniqueEntityView>
    {
        [TestMethod] public void UnitPriceTest() => isDisplayProperty<decimal>("Unit price", false);
        [TestMethod] public void QuantityTest() => isDisplayProperty<int>("Quantity", false);
        [TestMethod] public void CryptoIDTest() => isDisplayProperty<string>("Crypto");
        [TestMethod] public void CryptoNameTest() => isDisplayProperty<string>("Crypto");
        [TestMethod] public void CryptoBasketIDTest() => isDisplayProperty<string>("CryptoBasket");
        [TestMethod] public void TotalPriceTest() => isDisplayProperty<decimal>("Total price", false);
        [TestMethod] public void TickerTest() => isDisplayProperty<string>("Ticker");
        [TestMethod] public void BlockChainTest() => isDisplayProperty<string>("BlockChain");
    }
}
