using System;
using BankingApp.Aids.Methods;
using BankingApp.Data.Loan;

namespace BankingApp.Domain.Loans
{
	public sealed class PersonalLoan : Loan<PersonalLoanData>
	{
		public PersonalLoan(PersonalLoanData d) : base(d) { }
		public string Reason => Data?.Reason ?? Unspecified;

        public double MonthlyReturn
            => Safe.Run(() => Math.Round(MoneyAmount / Convert.ToDouble(LoanPeriod) + MoneyAmount / Convert.ToDouble(LoanPeriod) * Interest / 100, 2), UnspecifiedDouble);
	}
}
