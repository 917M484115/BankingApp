using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Loan
{
	public sealed class LoanManagerRepository :
		UniqueEntitiesRepository<LoanManager, LoanManagerData>, ILoanManagerRepository
	{
		public LoanManagerRepository(ApplicationDbContext c) : base(c, c.LoanManagers) { }
		protected internal override LoanManager toDomainObject(LoanManagerData d)
			=> new LoanManager(d);
	}
}
