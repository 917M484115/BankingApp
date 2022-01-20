using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Misc
{
    [TestClass]
    public class BankViewFactoryTests : FactoryBaseTests<BankViewFactory, BankData, Bank, BankView>
    {
        protected override Bank createObject(BankData d) => new(d);
    }
}
