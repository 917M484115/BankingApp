using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Loan
{
	public abstract class LoanView: MoneyAmountView
	{
		[DisplayName("Loan period")] public int LoanPeriod { get; set; }
		public double Interest { get; set; }
		[DisplayName("Loan manager Id")] public string LoanManagerId { get; set; }
	}
}
