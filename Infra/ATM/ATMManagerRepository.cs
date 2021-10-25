using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.ATM;
using BankingApp.Domain.ATMs;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.ATM
{
	public sealed class ATMManagerRepository :
		UniqueEntitiesRepository<ATMManager, ATMManagerData>, IATMManagerRepository
	{
		public ATMManagerRepository(ApplicationDbContext c) : base(c, c.ATMManager) { }
		protected internal override ATMManager toDomainObject(ATMManagerData d)
			=> new ATMManager(d);
	}
}
