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
    public class BlockChainRepositoryTests : RepoTests<BlockChainRepository, BlockChain, BlockChainData>
    {
        protected override object createObject()
            => new BlockChainRepository(new InMemoryApplicationDbContext().AppDb);
        protected override BlockChain toObject(BlockChainData d) => new(d);
    }
}
