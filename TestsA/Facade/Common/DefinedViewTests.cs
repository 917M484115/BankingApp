using BankingApp.Facade.Common;
using BankingApp.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Common {

    [TestClass]
    public class DefinedViewTests : AbstractClassTests<NamedView> {

        private class testClass: DefinedView { }
        [TestMethod] public void DefinitionTest() => isDisplayProperty<string>("Definition");
        protected override object createObject() => new testClass();
    }

}