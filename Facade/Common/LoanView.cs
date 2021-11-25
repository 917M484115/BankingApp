using System.ComponentModel;

namespace BankingApp.Facade.Common
{
	public class LoanView: MoneyAmountView
	{
		[DisplayName("Loan period")] public int LoanPeriod { get; set; }
		public double Interest { get; set; }
		[DisplayName("Loan manager Id")] public string LoanManagerId { get; set; }

        [DisplayName("Monthly return")] public string MonthlyReturn { get; set; }
	}
}
