//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using BankingApp.Data.Loan;
//using BankingApp.Infra.Common;

//namespace BankingApp.Infra.Loan
//{
//    public abstract class LoanRepository :
//        UniqueEntitiesRepository<Loan, LoanData>, ILoanRepository
//    {
//        public LoanRepository(ApplicationDbContext c) : base(c, c.Loan) { }
//        protected internal override Loan toDomainObject(LoanData d)
//            => new Loan(d);
//    }
//}
//TODO LoanRepository