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
    public class OrderItemViewTests : SealedClassTests<UniqueEntityView>
    {
        [TestMethod] public void OrderIDTest() => isDisplayProperty<string>("Order");
        [TestMethod] public void CryptoIDTest() => isDisplayProperty<string>("Crypto");
        [TestMethod] public void CryptoNameTest() => isDisplayProperty<string>("Crypto Name");
        [TestMethod] public void OrderTimeTest() => isDisplayProperty<DateTime>("Order Date", false);
        [TestMethod] public void UnitPriceTest() => isDisplayProperty<decimal>("Unit price", false);
        [TestMethod] public void UnitsTest() => isDisplayProperty<int>("Units", false);
        [TestMethod] public void TickerTest() => isDisplayProperty<string>("Ticker");
        [TestMethod] public void BlockChainTest() => isDisplayProperty<string>("BlockChain");
        [TestMethod] public void TotalPriceTest() => isDisplayProperty<decimal>("Total Price", false);
    }
}
