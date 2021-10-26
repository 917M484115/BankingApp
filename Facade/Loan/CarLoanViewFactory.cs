using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Loan
{
	public sealed class CarLoanViewFactory : AbstractViewFactory<CarLoanData, CarLoan, CarLoanView>
	{
		protected internal override CarLoan toObject(CarLoanData d) => new CarLoan(d);

		public override CarLoanView Create(CarLoan o)
		{
			var v = base.Create(o);
			v.CarType = o.CarType;
			v.CarAge = o.CarAge;
			v.CarValue = o.CarValue;
			return v;
		}
	}
}
