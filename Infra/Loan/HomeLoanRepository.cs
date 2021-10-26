using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Loan
{
	public sealed class HomeLoanRepository :
		UniqueEntitiesRepository<HomeLoan, HomeLoanData>, IHomeLoanRepository
	{
		public HomeLoanRepository(ApplicationDbContext c) : base(c, c.HomeLoan) { }
		protected internal override HomeLoan toDomainObject(HomeLoanData d)
			=> new HomeLoan(d);
	}
}
