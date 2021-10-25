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
	public sealed class PersonalLoanViewFactory : AbstractViewFactory<PersonalLoanData, PersonalLoan, PersonalLoanView>
	{
		protected internal override PersonalLoan toObject(PersonalLoanData d) => new PersonalLoan(d);

		public override PersonalLoanView Create(PersonalLoan o)
		{
			var v = base.Create(o);
			v.Reason = o.Reason;
			return v;
		}
	}
}
