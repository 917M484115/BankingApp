using BankingApp.Aids;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Common
{
    [TestClass]
    public class NamedEntityDataTests : AbstractClassTests<UniqueEntityData>
    {
        private class testClass : NamedEntityData { }
        protected override object createObject() => new testClass();
        [TestMethod] public void CodeTest() => isProperty<string>();
        [TestMethod] public void NameTest() => isProperty<string>();
    }
}
