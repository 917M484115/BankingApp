using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Infra.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Infra.Misc
{
    [TestClass]
    public class CustomersRepositoryTests : RepoTests<CustomersRepository, Customer, CustomerData>
    {
        protected override object createObject()
            => new CustomersRepository(new InMemoryApplicationDbContext().AppDb);
        protected override Customer toObject(CustomerData d) => new(d);
    }
}
