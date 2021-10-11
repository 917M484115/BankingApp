using Aids;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Common
{
    [TestClass]
    public class NamedDataTests : AbstractClassTests<NamedData, BaseData>
    {
        private class testClass : NamedData { }
        protected override NamedData getObject() => GetRandom.ObjectOf<testClass>();
        [TestMethod] public void NameTest() => isReadWriteProperty<string>();
    }
}
