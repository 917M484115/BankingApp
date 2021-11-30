using BankingApp.Data.Common;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Loan
{
	public sealed class HomeLoanViewFactory : AbstractViewFactory<HomeLoanData, HomeLoan, HomeLoanView>
	{
		protected internal override HomeLoan toObject(HomeLoanData d) => new HomeLoan(d);

		public override HomeLoanView Create(HomeLoan o)
		{
			var v = base.Create(o);
			v.HomeAge = o.HomeAge;
			v.HomeValue = o.HomeValue;
			v.MonthlyReturn = o.MonthlyReturn;
            return v;
		}
	}
}
