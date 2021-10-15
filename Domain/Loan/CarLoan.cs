using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.ATM;
using BankingApp.Data.Loan;

namespace BankingApp.Domain.Loan
{
	public sealed class CarLoan : Loan<CarLoanData>
	{
		public CarLoan(CarLoanData d) : base(d) { }
		public string CarType => Data?.CarType ?? "Unspecified";
		public double CarValue => Data?.CarValue ?? 0;
		public int CarAge => Data?.CarAge ?? 0;
	}
}
