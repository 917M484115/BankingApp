
using BankingApp.Data.Loan;
using BankingApp.Domain.Common;


namespace BankingApp.Domain.Loans
{
	public sealed class LoanAccount : AccountEntity<LoanAccountData>
	{
		public LoanAccount(LoanAccountData d) : base(d) { }
	}
}
