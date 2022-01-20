using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra.Loan
{
    [TestClass]
    public class LoanManagerRepositoryTests : RepoTests<LoanManagerRepository, LoanManager, LoanManagerData>
    {
        protected override object createObject()
            => new LoanManagerRepository(new InMemoryApplicationDbContext().AppDb);
        protected override LoanManager toObject(LoanManagerData d) => new(d);
    }
}