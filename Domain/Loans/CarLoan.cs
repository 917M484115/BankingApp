using System;
using BankingApp.Aids.Methods;
using BankingApp.Data.Loan;

namespace BankingApp.Domain.Loans
{
	public sealed class CarLoan : Loan<CarLoanData>
	{
		public CarLoan(CarLoanData d) : base(d) { }
		public string CarType => Data?.CarType ?? Unspecified;
		public double CarValue => Data?.CarValue ?? UnspecifiedDouble;
		public int CarAge => Data?.CarAge ?? UnspecifiedInteger;

        public double MonthlyReturn
            => Safe.Run(() => Math.Round(MoneyAmount / Convert.ToDouble(LoanPeriod) + MoneyAmount / Convert.ToDouble(LoanPeriod) * Interest / 100, 2), UnspecifiedDouble);
	}
}
