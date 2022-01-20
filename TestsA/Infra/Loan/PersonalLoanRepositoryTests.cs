using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra.Loan
{
    [TestClass]
    public class PersonalLoanRepositoryTests : RepoTests<PersonalLoanRepository, PersonalLoan, PersonalLoanData>
    {
        protected override object createObject()
            => new PersonalLoanRepository(new InMemoryApplicationDbContext().AppDb);
        protected override PersonalLoan toObject(PersonalLoanData d) => new(d);
    }
}