using Aids;
using BankingApp.Data;
using BankingApp.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Domain.Common
{
    [TestClass]
    public class BaseEntityTests : AbstractClassTests<BaseEntity<ATMData>, object>
    {
        private class testClass : BaseEntity<ATMData>
        {
            public testClass(ATMData d = null) : base(d) { }
        }

        protected override BaseEntity<ATMData> getObject() => new testClass(GetRandom.ObjectOf<ATMData>());

        [TestMethod]
        public void DataTest()
        {
            isReadOnlyProperty<ATMData>();
            Assert.AreNotSame(obj.Data, obj.Data);
            Assert.AreNotEqual(obj.Data, obj.Data);
            arePropertiesEqual(obj.Data, obj.Data);
            var actual = obj.Data;
            var expected = GetRandom.ObjectOf<ATMData>();
            Copy.Members(expected, actual);
            arePropertiesEqual(expected, actual);
            arePropertiesNotEqual(expected, obj.Data);
        }
        [TestMethod] public void IdTest() => isReadOnlyProperty(obj.Data.Id);
        [TestMethod] public void RowVersionTest() => isReadOnlyProperty(obj.Data.RowVersion);
    }
}
