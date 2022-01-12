using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Infra.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Infra.Misc
{
    public sealed class CustomersRepository :
        UniqueEntitiesRepository<Customer, CustomerData>, ICustomersRepository
    {
        public CustomersRepository(ApplicationDbContext c) : base(c, c.Customer) { }
        protected internal override Customer toDomainObject(CustomerData d)
            => new Customer(d);
    }
}
