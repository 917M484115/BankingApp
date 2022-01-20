using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Loan;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra.Loan
{
    [TestClass]
    public class CarLoanRepositoryTests : RepoTests<CarLoanRepository, CarLoan, CarLoanData>
    {
        protected override object createObject()
            => new CarLoanRepository(new InMemoryApplicationDbContext().AppDb);
        protected override CarLoan toObject(CarLoanData d) => new(d);
    }
}
