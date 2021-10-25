using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Facade.Loan
{
	public sealed class PersonalLoanView: LoanView
	{
		public string Reason { get; set; }
	}
}
