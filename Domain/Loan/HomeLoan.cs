﻿using BankingApp.Data.Loan;

namespace BankingApp.Domain.Loan
{
	public sealed class HomeLoan : Loan<HomeLoanData>
	{
		public HomeLoan(HomeLoanData d) : base(d) { }
		public double HomeValue => Data?.HomeValue ?? 0;
		public int HomeAge => Data?.HomeAge ?? 0;
	}
}