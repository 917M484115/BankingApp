using BankingApp.Data.Loan;

namespace BankingApp.Domain.Loans
{
	public sealed class CarLoan : Loan<CarLoanData>
	{
		public CarLoan(CarLoanData d) : base(d) { }
		public string CarType => Data?.CarType ?? Unspecified;
		public double CarValue => Data?.CarValue ?? UnspecifiedDouble;
		public int CarAge => Data?.CarAge ?? UnspecifiedInteger;
	}
}
