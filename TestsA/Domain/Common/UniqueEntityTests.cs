using BankingApp.Aids.Random;
using BankingApp.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Common
{
    [TestClass]
    public class UniqueEntityTests : AbstractClassTests<Entity<TestData>>
    {
        private TestData data;

        private class testClass : UniqueEntity<TestData>
        {
            public testClass(TestData d) : base(d) { }
        }
        protected override object createObject()
        {
            data = GetRandom.Object<TestData>();
            return new testClass(data);
        }
        [TestMethod] public void IdTest() => isProperty(data.Id);
    }
}
