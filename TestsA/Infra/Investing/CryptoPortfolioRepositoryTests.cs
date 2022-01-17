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
    public class CryptoPortfolioRepositoryTests : RepoTests<CryptoPortfolioRepository, CryptoPortfolio, CryptoPortfolioData>
    {
        protected override object createObject()
            => new CryptoPortfolioRepository(new InMemoryApplicationDbContext().AppDb);

        protected override CryptoPortfolio toObject(CryptoPortfolioData d) => new(d);

        //[TestMethod]
        //public async Task AddItemTest()
        //{
        //    var b = new CryptoBasket(random<CryptoBasketData>());
        //    var p = new Crypto(random<CryptoData>());
        //    await repo.AddItems(b, b.CustomerID);
        //    var i = p.Id;
        //    var d = dbSet.Find(i);
        //    //areEqual(b.Id, d.CryptoID);
        //    areEqual(p.Id, d.CryptoID);
        //    areEqual(1, d.CustomerID);
        //}
    }
}
