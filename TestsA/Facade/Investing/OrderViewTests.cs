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
    public class OrderViewTests : SealedClassTests<UniqueEntityView>
    {
        [TestMethod] public void CustomerIDTest() => isDisplayProperty<string>("Customer");
        [TestMethod] public void OrderDateTest() => isDisplayProperty<DateTime>("Started Trading", false);
        [TestMethod] public void CustomerNameTest() => isDisplayProperty<string>("Customer Name");
        [TestMethod] public void TotalPriceTest() => isDisplayProperty<decimal>("Total price", false);
        [TestMethod] public void ClosedTest() => isDisplayProperty<bool>("Closed", false);
    }
}
