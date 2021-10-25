using BankingApp.Aids;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Common
{
    [TestClass]
    public class MoneyAmountDataTests : AbstractClassTests<MoneyAmountData, UniqueEntityData>
    {
        private class testClass : MoneyAmountData { }
        protected override MoneyAmountData getObject() => GetRandom.ObjectOf<testClass>();
        [TestMethod] public void MoneyAmountTest() => isReadWriteProperty<double>();
    }
}
