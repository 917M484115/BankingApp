using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data;
using BankingApp.Data.Investing;
using BankingApp.Domain.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Loan
{
	public sealed class LoanAccountRepository :
		UniqueEntitiesRepository<LoanAccount, LoanAccountData>, ILoanAccountRepository
	{
		public LoanAccountRepository(ApplicationDbContext c) : base(c, c.LoanAccount) { }
		protected internal override LoanAccount toDomainObject(LoanAccountData d)
			=> new LoanAccount(d);
	}
}
