using BankingApp.Data.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Loan
{
    [TestClass]
    public class CarLoanDataTests : SealedClassTests<CarLoanData, LoanData>
    {
        [TestMethod] public void CarTypeTest() => isReadWriteProperty<string>();
        [TestMethod] public void CarValueTest() => isReadWriteProperty<double>();
        [TestMethod] public void CarAgeTest() => isReadWriteProperty<int>();
    }
}
