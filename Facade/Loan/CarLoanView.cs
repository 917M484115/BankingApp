using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Facade.Loan
{
	public abstract class CarLoanView: LoanView
	{
		[DisplayName("Car type")] public string CarType { get; set; }
		[DisplayName("Car value")] public double CarValue { get; set; }
		[DisplayName("Car age")] public int CarAge { get; set; }
	}
}
