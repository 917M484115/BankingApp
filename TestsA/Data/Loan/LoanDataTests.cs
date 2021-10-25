using BankingApp.Aids;
using BankingApp.Data.Common;
using BankingApp.Data.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Loan
{
    [TestClass]
    public class LoanDataTests : AbstractClassTests<LoanData, MoneyAmountData>
    {
        private class testClass : LoanData { }
        protected override LoanData getObject() => GetRandom.ObjectOf<testClass>();
        [TestMethod] public void LoanPeriodTest() => isReadWriteProperty<int>();
        [TestMethod] public void InterestTest() => isReadWriteProperty<double>();
        [TestMethod] public void LoanManagerIdTest() => isReadWriteProperty<string>();
    }
}
