using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Misc
{
	public interface ICustomersRepository : IRepository<Customer> { }
}
