using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingApp.Aids.Reflection;

namespace BankingApp.Tests.Aids
{
    [TestClass]
    public class GetEnumTests
    {
        private enum testEnum
        {
            Undefined = 0,
            First = 1,
            Second = 123
        }
        [TestMethod]
        public void CountTest()
            => Assert.AreEqual(3, GetEnum.Count<testEnum>());
        [TestMethod]
        public void CountTestByType()
            => Assert.AreEqual(3, GetEnum.Count(typeof(testEnum)));

        [TestMethod]
        public void ValueByIndexTest()
            => Assert.AreEqual(testEnum.First, GetEnum.Value<testEnum>(1));
        [TestMethod]
        public void ValueByIndexTestByType()
            => Assert.AreEqual(testEnum.Second, GetEnum.Value(typeof(testEnum), 2));

        [TestMethod]
        public void ValueByValueTest()
            => Assert.AreEqual(testEnum.First, GetEnum.Value<testEnum>(1));
        //[TestMethod]
        //public void ValueByValueTestByType()
        //    => Assert.AreEqual(testEnum.Second, GetEnum.Value(typeof(testEnum), 123));

        [TestMethod]
        public void CountTestWrongType()
            => Assert.AreEqual(-1, GetEnum.Count<string>());
        [TestMethod]
        public void CountTestByTypeWrongType()
            => Assert.AreEqual(-1, GetEnum.Count(typeof(int)));

        [TestMethod]
        public void ValueByIndexTestWrongIndex()
            => Assert.AreEqual(testEnum.Undefined, GetEnum.Value<testEnum>(100));
        //[TestMethod]
        //public void ValueByIndexTestByTypeWrongIndex()
        //    => Assert.AreEqual(testEnum.Undefined, GetEnum.Value(typeof(testEnum), 100));

        [TestMethod]
        public void ValueByValueTestWrongIndex()
            => Assert.AreEqual(testEnum.Undefined, GetEnum.Value<testEnum>(100));
        //[TestMethod]
        //public void ValueByValueTestByTypeWrongIndex()
        //    => Assert.AreEqual(testEnum.Undefined, GetEnum.Value(typeof(testEnum), 100));

        [TestMethod]
        public void ValueByIndexTestWrongType()
            => Assert.AreEqual(null, GetEnum.Value<string>(100));
        [TestMethod]
        public void ValueByIndexTestByTypeWrongType()
            => Assert.AreEqual(null, GetEnum.Value(typeof(string), 100));

        [TestMethod]
        public void ValueByValueTestWrongType()
            => Assert.AreEqual(0, GetEnum.Value<int>(100));
        //[TestMethod]
        //public void ValueByValueTestByTypeWrongType()
        //    => Assert.AreEqual(0, GetEnum.Value(typeof(int), 100));

    }
}
