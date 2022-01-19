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
    public class CalculatorViewTests : SealedClassTests<NamedView>
    {
        [TestMethod] public void APYTest() => isDisplayProperty<double>("APY", false);
        [TestMethod] public void TimeInMonthsTest() => isDisplayProperty<double>("TimeInMonths", false);
        [TestMethod] public void AmountTest() => isDisplayProperty<double>("Amount", false);
        [TestMethod] public void ResultTest() => isDisplayProperty<double>("Result", false);
        [TestMethod] public void RevenueTest() => isDisplayProperty<double>("Revenue", false);
    }
}
