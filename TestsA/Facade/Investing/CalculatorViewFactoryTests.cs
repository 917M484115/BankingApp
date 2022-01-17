using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;
using BankingApp.Facade.Investing;
using BankingApp.Tests;
using BankingApp.Tests.Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Investing
{
    [TestClass]
    public class CalculatorViewFactoryTests : FactoryBaseTests<CalculatorViewFactory, CalculatorData, Calculator, CalculatorView>
    {
        protected override Calculator createObject(CalculatorData d) => new(d);
    }
}
