using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data;
using BankingApp.Domain.Loan;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Loan
{
	public sealed class LoanManagerViewFactory : AbstractViewFactory<LoanManagerData, LoanManager, LoanManagerView>
	{
		protected internal override LoanManager toObject(LoanManagerData d) => new LoanManager(d);
	}
}
