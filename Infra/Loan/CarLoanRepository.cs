using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Investing;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Loan
{
	public sealed class CarLoanRepository :
		UniqueEntitiesRepository<CarLoan, CarLoanData>, ICarLoanRepository
	{
		public CarLoanRepository(ApplicationDbContext c) : base(c, c.CarLoan) { }
		protected internal override CarLoan toDomainObject(CarLoanData d)
			=> new CarLoan(d);
	}
}
