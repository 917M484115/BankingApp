using BankingApp.Data;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Loan
{
	public sealed class LoanManager : PersonEntity<LoanManagerData>
	{
		public LoanManager(LoanManagerData d) : base(d) { }
	}
}
