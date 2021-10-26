using BankingApp.Data.Loan;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Loans
{
	public abstract class Loan<T> : MoneyAmountEntity<T> where T : LoanData, new()
	{
		public Loan(T d) : base(d) { }
		public string LoanManagerId => Data?.LoanManagerId ?? Unspecified;
		public int LoanPeriod => Data?.LoanPeriod ?? 0;
		public double Interest => Data?.Interest ?? 0;
	}
}
