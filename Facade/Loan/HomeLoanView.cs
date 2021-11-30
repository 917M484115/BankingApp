using System.ComponentModel;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Loan
{
	public sealed class HomeLoanView: LoanView
	{
		[DisplayName("Home value")] public double HomeValue { get; set; }
		[DisplayName("Home age")] public int HomeAge { get; set; }
    }
}
