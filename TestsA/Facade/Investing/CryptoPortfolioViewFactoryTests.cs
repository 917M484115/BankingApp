using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Investing
{
    [TestClass]
    public class CryptoPortfolioViewFactoryTests : FactoryBaseTests<CryptoPortfolioViewFactory, CryptoPortfolioData, CryptoPortfolio, CryptoPortfolioView>
    {
        protected override string[] excludeProperties => new string[] { "BuyerName", "BuyerAddress", "Closed", "TotalPrice" };
        protected override void doBeforeCreateViewTest(CryptoPortfolioData d)
        {
            var r = MockRepos.CrpytoPortfolioRepo(d.CryptoID, out _);
            GetRepository.SetServiceProvider(new MockServiceProvider(r));
        }
        protected override void doAfterCreateViewTest(CryptoPortfolio o, CryptoPortfolioView v)
        {
            areEqual(o.Crypto.Name, v.CryptoName);
            areEqual(o.TotalPrice, v.TotalPrice);
        }
        protected override CryptoPortfolio createObject(CryptoPortfolioData d) => new(d);
    }
}
