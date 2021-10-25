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
	public sealed class InvestmentRepository :
		UniqueEntitiesRepository<Investment, InvestmentData>, IInvestmentRepository
	{
		public InvestmentRepository(ApplicationDbContext c) : base(c, c.Investment) { }
		protected internal override Investment toDomainObject(InvestmentData d)
			=> new Investment(d);
	}
}
