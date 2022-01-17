using BankingApp.Aids.Random;
using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Common
{
    public class TestData : DefinedEntityData { }

    [TestClass] public class DefinedEntityTests : AbstractClassTests<NamedEntity<TestData>> {
        private TestData data;

        private class testClass: DefinedEntity<TestData> { 
            public testClass(TestData d) : base(d) { }
        }
        protected override object createObject()
        {
            data = GetRandom.Object<TestData>();
            return new testClass(data);
        }
        [TestMethod] public void DefinitionTest() => isProperty(data.Definition);
    }
}
