using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra.Loan
{
    [TestClass]
    public class LoanAccountRepositoryTests : RepoTests<LoanAccountRepository, LoanAccount, LoanAccountData>
    {
        protected override object createObject()
            => new LoanAccountRepository(new InMemoryApplicationDbContext().AppDb);
        protected override LoanAccount toObject(LoanAccountData d) => new(d);
    }
}
