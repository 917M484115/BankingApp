using BankingApp.Aids;
using BankingApp.Core;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Common
{
    [TestClass]
    public class BaseDataTests : AbstractClassTests<BaseData, UniqueItem>
    {
        private class testClass : BaseData { }
        protected override BaseData getObject() => GetRandom.ObjectOf<testClass>();
        [TestMethod] public void RowVersionTest() => isReadWriteProperty<byte[]>();

    }
}
