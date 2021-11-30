
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Loan
{
	public sealed class LoanAccountViewFactory : AbstractViewFactory<LoanAccountData, LoanAccount, LoanAccountView>
	{
		protected internal override LoanAccount toObject(LoanAccountData d) => new LoanAccount(d);
		public override LoanAccountView Create(LoanAccount o)
		{
			var v = base.Create(o);
			v.MoneyAmount = o.MoneyAmount;
            v.AccountAddress = o.AccountAddress;
			return v;
		}
	}
}
