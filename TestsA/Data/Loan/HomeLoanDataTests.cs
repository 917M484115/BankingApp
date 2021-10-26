using BankingApp.Data.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Loan
{
    [TestClass]
    public class HomeLoanDataTests : SealedClassTests<LoanData>
    {
        [TestMethod] public void HomeValueTest() => isProperty<double>();
        [TestMethod] public void HomeAgeTest() => isProperty<int>();
    }
}
