using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;

namespace BankingApp.Infra.Loan
{
	public sealed class HomeLoanRepository :
		LoanRepository<HomeLoan, HomeLoanData>, IHomeLoanRepository
	{
		public HomeLoanRepository(ApplicationDbContext c) : base(c, c.HomeLoan) { }
		protected internal override HomeLoan toDomainObject(HomeLoanData d)
			=> new HomeLoan(d);
	}
}
