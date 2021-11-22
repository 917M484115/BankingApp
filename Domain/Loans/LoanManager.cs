using BankingApp.Data.Loan;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Loans
{
	public sealed class LoanManager : PersonEntity<LoanManagerData>
	{
		public LoanManager(LoanManagerData d) : base(d) { }
	}
}
