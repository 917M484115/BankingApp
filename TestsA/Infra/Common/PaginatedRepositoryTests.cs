using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Common;
using BankingApp.Infra.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra.Common
{

    [TestClass]
    public class PaginatedRepositoryTests : AbstractRepoTests<BlockChainRepository, BlockChain, BlockChainData> {
        protected override object createObject()
            => new BlockChainRepository(new InMemoryApplicationDbContext().AppDb);
        protected override BlockChain toObject(BlockChainData d) => new(d);
        [TestMethod]
        public override void IsInheritedTest() {
            var b = getBaseClass();
            isTrue(b.Name.StartsWith(nameof(FilteredRepository<BlockChain, BlockChainData>)));
        }
        [TestMethod] public void PageIndexTest() => isProperty<int>(false);
        [TestMethod] public void TotalPagesTest() => isProperty(repo.getTotalPages(repo.PageSize));
        [TestMethod] public void HasNextPageTest() => isBooleanProperty(repo.PageIndex < repo.TotalPages);
        [TestMethod] public void HasPreviousPageTest() => isBooleanProperty(repo.PageIndex > 1);
        [TestMethod] public void PageSizeTest() => isProperty<int>(false);
        [TestMethod]
        public void SqlQueryTest() {
            var b = repo.createSqlQuery().Expression.ToString();
            isFalse(b.Contains(".Skip"));
            isFalse(b.Contains(".Take"));
            repo.PageIndex = 1;
            b = repo.createSqlQuery().Expression.ToString();
            isTrue(b.Contains(".Skip"));
            isTrue(b.Contains(".Take"));
        }
    }
}