using BankingApp.Data.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Loan
{
    [TestClass]
    public class CarLoanDataTests : SealedClassTests<LoanData>
    {
        [TestMethod] public void CarTypeTest() => isProperty<string>();
        [TestMethod] public void CarValueTest() => isProperty<double>();
        [TestMethod] public void CarAgeTest() => isProperty<int>();
    }
}
