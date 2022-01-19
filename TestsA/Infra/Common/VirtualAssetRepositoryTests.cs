using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Common;
using BankingApp.Infra.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Infra.Common
{
    [TestClass]
    public class VirtualAssetRepositoryTests : AbstractRepoTests<BlockChainRepository, BlockChain, BlockChainData>
    {
        protected override object createObject()
            => new BlockChainRepository(new InMemoryApplicationDbContext().AppDb);

        protected override BlockChain toObject(BlockChainData d) => new(d);

        [TestMethod]
        public override void IsInheritedTest()
        {
            var b = getBaseClass();
            isTrue(b.Name.StartsWith(nameof(UniqueEntitiesRepository<BlockChain, BlockChainData>)));
        }
    }
}
