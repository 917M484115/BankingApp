using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Domain.Common;
using BankingApp.Domain.Loan;

namespace BankingApp.Domain.Loans
{
	public interface ICarLoanRepository : IRepository<CarLoan> { }
}
