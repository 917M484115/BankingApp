
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Investing
{
	public sealed class InvestingAccountRepository :
		AccountRepository<InvestingAccount, InvestingAccountData>, IInvestingAccountRepository
	{
		public InvestingAccountRepository(ApplicationDbContext c) : base(c, c.InvestingAccount) { }
		protected internal override InvestingAccount toDomainObject(InvestingAccountData d)
			=> new InvestingAccount(d);
	}
}
