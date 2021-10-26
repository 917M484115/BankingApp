using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Loan
{
	public sealed class LoanManagerRepository :
		UniqueEntitiesRepository<LoanManager, LoanManagerData>, ILoanManagerRepository
	{
		public LoanManagerRepository(ApplicationDbContext c) : base(c, c.LoanManager) { }
		protected internal override LoanManager toDomainObject(LoanManagerData d)
			=> new LoanManager(d);
	}
}
