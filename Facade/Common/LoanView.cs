using System.ComponentModel;

namespace BankingApp.Facade.Common
{
	public abstract class LoanView: MoneyAmountView
	{
		[DisplayName("Loan period")] public int LoanPeriod { get; set; }
		public double Interest { get; set; }
		[DisplayName("Loan manager Id")] public string LoanManagerId { get; set; }
	}
}
