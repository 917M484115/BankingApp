using BankingApp.Data.Loan;
using BankingApp.Domain.Common;
using BankingApp.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BankingApp.Tests.Domain.Loans
{
    [TestClass]
    public class LoanAccountTests : SealedClassTests<AccountEntity<LoanAccountData>>
    {
    }
}

