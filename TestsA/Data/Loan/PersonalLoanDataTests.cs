using BankingApp.Data.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Loan
{
    [TestClass]
    public class PersonalLoanDataTests:SealedClassTests<PersonalLoanData,LoanData>
    {
        [TestMethod] public void ReasonTest() => isReadWriteProperty<string>();
    }
}
