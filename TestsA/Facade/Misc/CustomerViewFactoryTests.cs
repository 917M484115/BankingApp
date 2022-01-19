using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Misc
{
    [TestClass]
    public class CustomerViewFactoryTests : FactoryBaseTests<CustomerViewFactory, CustomerData, Customer, CustomerView>
    {
        protected override Customer createObject(CustomerData d) => new(d);
    }
}
