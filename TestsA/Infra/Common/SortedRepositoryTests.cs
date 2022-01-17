using BankingApp.Data.Investing;
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
    public class SortedRepositoryTests : AbstractRepoTests<BlockChainRepository, BlockChain, BlockChainData> {
        protected override object createObject()
            => new BlockChainRepository(new InMemoryApplicationDbContext().AppDb);

        protected override BlockChain toObject(BlockChainData d) => new(d);

        [TestMethod]
        public override void IsInheritedTest() {
            var b = getBaseClass();
            isTrue(b.Name.StartsWith(nameof(BaseRepository<BlockChain, BlockChainData>)));
        }

        [TestMethod] public void SortOrderTest() => isProperty<string>();
        [TestMethod] public void DescendingStringTest() => isProperty("_desc");

        [DataTestMethod]
        [DataRow(null, false, false)]
        [DataRow(nameof(BlockChainData.Name), true, false)]
        [DataRow(nameof(BlockChainData.Name) + "_desc", true, true)]
        public void SqlQueryTest(string s, bool hasOrderBy, bool hasDescending) {
            repo.SortOrder = s;
            var b = repo.createSqlQuery().Expression.ToString();
            areEqual(hasOrderBy, b.Contains(".OrderBy"));
            areEqual(hasDescending, b.Contains(".OrderByDescending"));
        }
    }
}