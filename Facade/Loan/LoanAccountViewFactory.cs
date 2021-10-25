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
	public sealed class LoanAccountViewFactory : AbstractViewFactory<LoanAccountData, LoanAccount, LoanAccountView>
	{
		protected internal override LoanAccount toObject(LoanAccountData d) => new LoanAccount(d);
	}
}
