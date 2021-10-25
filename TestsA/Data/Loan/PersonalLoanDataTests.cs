using BankingApp.Data.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Loan
{
    [TestClass]
    public class PersonalLoanDataTests:SealedClassTests<PersonalLoanData,LoanData>
    {
        [TestMethod] public void ReasonTest() => isReadWriteProperty<string>();
    }
}
