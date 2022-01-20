using BankingApp.Aids;
using BankingApp.Aids.Random;
using BankingApp.Data.Common;
using BankingApp.Data.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Loan
{
    [TestClass]
    public class LoanDataTests : AbstractClassTests<MoneyAmountData>
    {
        private class testClass : LoanData { }
        protected override LoanData createObject() => GetRandom.Object<testClass>();
        [TestMethod] public void LoanPeriodTest() => isProperty<int>(false);
        [TestMethod] public void InterestTest() => isProperty<double>(false);
        [TestMethod] public void LoanManagerIdTest() => isProperty<string>();
    }
}
