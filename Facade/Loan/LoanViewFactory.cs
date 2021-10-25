//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using BankingApp.Data.Loan;
//using BankingApp.Domain.Loan;
//using BankingApp.Facade.Common;

//namespace BankingApp.Facade.Loan
//{
//	public sealed class LoanViewFactory : AbstractViewFactory<LoanData, Loan, LoanView>
//	{
//		protected internal override Loan toObject(LoanData d) => new Loan(d);

//		public override LoanView Create(Loan<> o)
//		{
//			var v = base.Create(o);
//			v.LoanPeriod = o.LoanPeriod;
//			v.Interest = o.Interest;
//			v.LoanManagerId = o.LoanManagerId;
//			return v;
//		}
//	}
//}
