using BankingApp.Pages.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages.Investing
{
    [TestClass] public class CryptoManagerPageTests : AuthorizedPageTests<CryptoManagerPage, CryptoBasePage<CryptoManagerPage>>
    {
        protected override object createObject()
            => new CryptoManagerPage(MockRepos.Cryptos(),
                MockRepos.CryptoBaskets(), MockRepos.CryptoBasketItems(), MockRepos.BlockChains());
        protected override string expectedUrl => "/Manager/Crypto";
        protected override List<string> expectedIndexPageColumns
            => new() {
                "Id",
                "Name",
                "Ticker",
                "BlockChainID",
                "Price"
            };
        
    }
}
