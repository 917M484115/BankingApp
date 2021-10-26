using BankingApp.Aids;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Common
{
    [TestClass]
    public class MoneyAmountDataTests : AbstractClassTests<UniqueEntityData>
    {
        private class testClass : MoneyAmountData { }
        protected override object createObject() => new testClass();
        [TestMethod] public void MoneyAmountTest() => isProperty<double>();
    }
}
