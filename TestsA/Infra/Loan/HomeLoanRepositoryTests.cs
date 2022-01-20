using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra.Loan
{
    [TestClass]
    public class HomeLoanRepositoryTests : RepoTests<HomeLoanRepository, HomeLoan, HomeLoanData>
    {
        protected override object createObject()
            => new HomeLoanRepository(new InMemoryApplicationDbContext().AppDb);
        protected override HomeLoan toObject(HomeLoanData d) => new(d);
    }
}
