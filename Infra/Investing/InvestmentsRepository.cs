using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Investing
{
	public sealed class InvestmentsRepository :
		UniqueEntitiesRepository<Investment, InvestmentData>, IInvestmentRepository
	{
		public InvestmentsRepository(ApplicationDbContext c) : base(c, c.Investment) { }
		protected internal override Investment toDomainObject(InvestmentData d)
			=> new Investment(d);
	}
}
