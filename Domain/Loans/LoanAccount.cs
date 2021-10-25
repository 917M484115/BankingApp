using BankingApp.Data;
using BankingApp.Domain.Misc;

namespace BankingApp.Domain.Loan
{
	public sealed class LoanAccount : AccountEntity<LoanAccountData>
	{
		public LoanAccount(LoanAccountData d) : base(d) { }
	}
}
