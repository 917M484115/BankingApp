using BankingApp.Data.Loan;
using System;
using BankingApp.Aids.Methods;


namespace BankingApp.Domain.Loans
{
	public sealed class HomeLoan : Loan<HomeLoanData>
	{
		public HomeLoan(HomeLoanData d) : base(d) { }
		public double HomeValue => Data?.HomeValue ?? 0;
		public int HomeAge => Data?.HomeAge ?? 0;

        public double MonthlyReturn
            => Safe.Run(() => Math.Round(HomeValue / Convert.ToDouble(LoanPeriod) + HomeValue / Convert.ToDouble(LoanPeriod) * Interest / 100, 2), UnspecifiedDouble);
    }
}
