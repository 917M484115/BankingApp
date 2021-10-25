using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Facade.Loan
{
	public abstract class HomeLoanView: LoanView
	{
		[DisplayName("Home value")] public double HomeValue { get; set; }
		[DisplayName("Home age")] public int HomeAge { get; set; }
	}
}
