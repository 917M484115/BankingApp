//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BankingApp.Infra.Loan
//{
//	public sealed class LoanRepository :
//		UniqueEntitiesRepository<Loan, LoanData>, ILoanRepository
//	{
//		public LoanRepository(ApplicationDbContext c) : base(c, c.Loan) { }
//		protected internal override Loan toDomainObject(LoanData d)
//			=> new Loan(d);
//	}
//}
