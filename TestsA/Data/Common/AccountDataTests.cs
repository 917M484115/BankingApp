using BankingApp.Aids;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Common
{
    [TestClass]
    public class AccountDataTests : AbstractClassTests<MoneyAmountData>
    {
        private class testClass : AccountData { }
        protected override object createObject() => new testClass();
        [TestMethod] public void AccountAddressTest() => isProperty<string>();
        [TestMethod] public void AccountOwnerNameTest() => isProperty<string>();
        [TestMethod] public void AccountLocationTest() => isProperty<string>();
    }
}
