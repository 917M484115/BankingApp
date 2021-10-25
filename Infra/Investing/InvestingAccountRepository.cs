using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Investing
{
	public sealed class InvestingAccountRepository :
		UniqueEntitiesRepository<InvestingAccount, InvestingAccountData>, IInvestingAccountRepository
	{
		public InvestingAccountRepository(ApplicationDbContext c) : base(c, c.InvestingAccount) { }
		protected internal override InvestingAccount toDomainObject(InvestingAccountData d)
			=> new InvestingAccount(d);
	}
}
