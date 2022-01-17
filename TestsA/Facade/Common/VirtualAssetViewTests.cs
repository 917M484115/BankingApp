using BankingApp.Facade.Common;
using BankingApp.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Common
{
    [TestClass]
    public class VirtualAssetViewTests : AbstractClassTests<NamedView>
    {

        private class testClass : VirtualAssetView { }
        [TestMethod] public void TickerTest() => isDisplayProperty<string>("Ticker");
        [TestMethod] public void PriceTest() => isDisplayProperty<decimal>("Price",false);
        protected override object createObject() => new testClass();
    }
}
