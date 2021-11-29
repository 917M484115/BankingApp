using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Loan
{
	public sealed class CarLoanRepository :
		LoanRepository<CarLoan, CarLoanData>, ICarLoanRepository
	{
		public CarLoanRepository(ApplicationDbContext c) : base(c, c.CarLoan) { }
		protected internal override CarLoan toDomainObject(CarLoanData d)
			=> new CarLoan(d);
	}
}
