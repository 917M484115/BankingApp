using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Infra.Investing
{
    [TestClass]
    public class CalculatorsRepositoryTests : RepoTests<CalculatorsRepository, Calculator, CalculatorData>
    {
        protected override object createObject()
            => new CalculatorsRepository(new InMemoryApplicationDbContext().AppDb);
        protected override Calculator toObject(CalculatorData d) => new(d);
    }
}
