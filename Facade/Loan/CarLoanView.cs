using System.ComponentModel;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Loan
{
	public sealed class CarLoanView: LoanView
	{
		[DisplayName("Car type")] public string CarType { get; set; }
		[DisplayName("Car value")] public double CarValue { get; set; }
		[DisplayName("Car age")] public int CarAge { get; set; }
	}
}
