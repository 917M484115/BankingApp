using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Common {

    [TestClass]
    public class NamedViewTests : AbstractClassTests<UniqueEntityView> {
        private class testClass: NamedView { }

        [TestMethod] public void CodeTest() => isDisplayProperty<string>("Code");
        [TestMethod] public void NameTest() => isRequiredProperty<string>("Name");

        protected override object createObject() => new testClass();
    }

}