using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Loan
{
	public sealed class LoanManagerViewFactory : AbstractViewFactory<LoanManagerData, LoanManager, LoanManagerView>
	{
		protected internal override LoanManager toObject(LoanManagerData d) => new LoanManager(d);
	}
}
