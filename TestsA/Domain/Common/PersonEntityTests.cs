//using BankingApp.Aids.Random;
//using BankingApp.Domain.Common;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace BankingApp.Tests.Domain.Common
//{
//    [TestClass]
//    public class PersonEntityTests : AbstractClassTests<NamedEntity<TestData>>
//    {
//        private TestData data;

//        private class testClass : NamedEntity<TestData>
//        {
//            public testClass(TestData d) : base(d) { }
//        }
//        protected override object createObject()
//        {
//            data = GetRandom.Object<TestData>();
//            return new testClass(data);
//        }
//        [TestMethod] public void AgeTest() => isProperty(data.Name);
//        [TestMethod] public void CountryTest() => isProperty(data.Code);
//    }
//}
