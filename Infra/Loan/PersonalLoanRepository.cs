using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Loan
{
	public sealed class PersonalLoanRepository :
		UniqueEntitiesRepository<PersonalLoan, PersonalLoanData>, IPersonalLoanRepository
	{
		public PersonalLoanRepository(ApplicationDbContext c) : base(c, c.PersonalLoan) { }
		protected internal override PersonalLoan toDomainObject(PersonalLoanData d)
			=> new PersonalLoan(d);
	}
}
