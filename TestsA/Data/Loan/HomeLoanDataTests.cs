using BankingApp.Data.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Loan
{
    [TestClass]
    public class HomeLoanDataTests : SealedClassTests<HomeLoanData, LoanData>
    {
        [TestMethod] public void HomeValueTest() => isReadWriteProperty<double>();
        [TestMethod] public void HomeAgeTest() => isReadWriteProperty<int>();
    }
}
