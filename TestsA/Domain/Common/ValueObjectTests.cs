using BankingApp.Aids.Random;
using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Common
{
    [TestClass]
    public class ValueObjectTests : AbstractClassTests<BaseEntity>
    {
        private TestData data;
        private class testClass : ValueObject<TestData>
        {
            public testClass(TestData d) : base(d) { }
        }
        protected override object createObject()
            => new testClass(data);
        [TestInitialize] public override void TestInitialize() {
            data = GetRandom.Object<TestData>();
            base.TestInitialize(); 
        }
        [TestMethod] public void IsUnspecifiedTest() { 
           isFalse((obj as testClass).IsUnspecified);
           obj = new testClass(null);
           isTrue((obj as testClass).IsUnspecified);
        }
    }
}
