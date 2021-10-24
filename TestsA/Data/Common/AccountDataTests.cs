using BankingApp.Aids;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Common
{
    [TestClass]
    public class AccountDataTests : AbstractClassTests<AccountData,MoneyAmountData>
    {
        private class testClass : AccountData { }
        protected override AccountData getObject() => GetRandom.ObjectOf<testClass>();
        [TestMethod] public void AccountAddressTest() => isReadWriteProperty<string>();
        [TestMethod] public void CustomerIdTest() => isReadWriteProperty<string>();
        [TestMethod] public void AccountLocationTest() => isReadWriteProperty<string>();
    }
}
