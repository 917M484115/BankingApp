using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
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
    public class CryptoViewFactoryTests : FactoryBaseTests<CryptoViewFactory, CryptoData, Crypto, CryptoView>
    {
        protected override Crypto createObject(CryptoData d) => new(d);
    }
}
