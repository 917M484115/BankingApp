using BankingApp.Data.Loan;

namespace BankingApp.Domain.Loans
{
	public sealed class PersonalLoan : Loan<PersonalLoanData>
	{
		public PersonalLoan(PersonalLoanData d) : base(d) { }
		public string Reason => Data?.Reason ?? Unspecified;
	}
}
