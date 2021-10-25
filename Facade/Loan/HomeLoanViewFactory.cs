using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loan;
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
			return v;
		}
	}
}
