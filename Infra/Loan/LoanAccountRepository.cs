using BankingApp.Data;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Loan
{
	public sealed class LoanAccountRepository :
		AccountRepository<LoanAccount, LoanAccountData>, ILoanAccountRepository
	{
		public LoanAccountRepository(ApplicationDbContext c) : base(c, c.LoanAccount) { }
		protected internal override LoanAccount toDomainObject(LoanAccountData d)
			=> new LoanAccount(d);
	}
}
