using BankingApp.Data.Loan;
using BankingApp.Aids;
using System;


namespace BankingApp.Domain.Loans
{
	public sealed class HomeLoan : Loan<HomeLoanData>
	{
		public HomeLoan(HomeLoanData d) : base(d) { }
		public double HomeValue => Data?.HomeValue ?? 0;
		public int HomeAge => Data?.HomeAge ?? 0;
		public double MonthlyReturn
		   => Safe.Run(() => Math.Round(HomeValue * Interest / Convert.ToDouble(LoanPeriod), 2), UnspecifiedDouble);

	}
}
