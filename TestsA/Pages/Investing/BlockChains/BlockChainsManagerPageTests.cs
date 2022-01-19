using BankingApp.Pages.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages.Investing
{
    [TestClass]
    public class BlockChainsManagerPageTests : AuthorizedPageTests<BlockChainsManagerPage, BlockChainsBasePage<BlockChainsManagerPage>>
    {
        protected override object createObject() => new BlockChainsManagerPage(MockRepos.BlockChains());
        protected override string expectedUrl => "/Manager/BlockChains";
        protected override List<string> expectedIndexPageColumns
            => new() {
                "Id",
                "Name"
            };
    }
}
