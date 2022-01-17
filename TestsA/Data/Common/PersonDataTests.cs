using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Common
{
    [TestClass]
    public class PersonDataTests : AbstractClassTests<NamedEntityData>
    {
        private class testClass : PersonData { }
        protected override object createObject() =>new testClass();
        [TestMethod] public void CountryTest() => isProperty<string>();
        [TestMethod] public void AgeTest() => isProperty<int>(false);
    }
}
