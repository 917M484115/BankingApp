using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Loan
{
	public sealed class HomeLoanRepository :
		LoanRepository<HomeLoan, HomeLoanData>, IHomeLoanRepository
	{
		public HomeLoanRepository(ApplicationDbContext c) : base(c, c.HomeLoans) { }
		protected internal override HomeLoan toDomainObject(HomeLoanData d)
			=> new HomeLoan(d);
	}
}
