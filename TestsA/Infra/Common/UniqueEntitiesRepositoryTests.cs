using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Infra;
using BankingApp.Infra.Common;
using BankingApp.Infra.Investing;
using BankingApp.Tests.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace BankingApp.Tests.Infra.Common
{

    [TestClass]
    public class UniqueEntitiesRepositoryTests : AbstractRepoTests<BlockChainRepository, BlockChain, BlockChainData> {
        protected override object createObject()
            => new BlockChainRepository(new InMemoryApplicationDbContext().AppDb);

        protected override BlockChain toObject(BlockChainData d) => new(d);

        [TestMethod]
        public override void IsInheritedTest() {
            var b = getBaseClass();
            isTrue(b.Name.StartsWith(nameof(PaginatedRepository<BlockChain, BlockChainData>)));
        }
    }
}
