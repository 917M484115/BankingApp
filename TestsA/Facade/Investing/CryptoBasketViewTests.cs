using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Investing
{
    [TestClass] public class CryptoBasketViewTests : SealedClassTests<UniqueEntityView>
    {
        [TestMethod] public void CustomerIDTest() => isDisplayProperty<string>("Customer email");
        [TestMethod] public void CustomerNameTest() => isDisplayProperty<string>("Customer name");
        [TestMethod] public void CustomerCountryTest() => isDisplayProperty<string>("Country");
        [TestMethod] public void TotalPriceTest() => isDisplayProperty<decimal>("Total price", false);
        [TestMethod] public void ClosedTest() => isDisplayProperty<bool>("Closed", false);
    }
}
