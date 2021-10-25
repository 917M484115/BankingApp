//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using BankingApp.Data.ATM;
//using BankingApp.Domain.ATMs;
//using BankingApp.Infra.Common;

//namespace BankingApp.Infra.ATM
//{
//	public sealed class ATMRepository :
//		UniqueEntitiesRepository<ATM, ATMData>, IATMRepository
//	{
//		public ATMRepository(ApplicationDbContext c) : base(c, c.ATM) { }
//		protected internal override ATM toDomainObject(ATMData d)
//			=> new ATM(d);
//	}
//}
