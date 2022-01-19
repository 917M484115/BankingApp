using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Common
{
    [TestClass]
    public class PersonViewTests:AbstractClassTests<NamedView> {

        private class testClass : PersonView { }
        [TestMethod] public void AgeTest() => isDisplayProperty<int>("Age", false);
        [TestMethod] public void CountryTest() => isDisplayProperty<string>("Country");
        protected override object createObject() => new testClass();
    }
}
