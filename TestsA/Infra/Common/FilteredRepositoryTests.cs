using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Common;
using BankingApp.Infra.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra.Common
{

    [TestClass]
    public class FilteredRepositoryTests : AbstractRepoTests<BlockChainRepository, BlockChain, BlockChainData> {
        protected override object createObject()
            => new BlockChainRepository(new InMemoryApplicationDbContext().AppDb);

        protected override BlockChain toObject(BlockChainData d) => new(d);

        [TestMethod]
        public override void IsInheritedTest() {
            var b = getBaseClass();
            isTrue(b.Name.StartsWith(nameof(SortedRepository<BlockChain, BlockChainData>)));
        }
        [TestMethod] public void SearchStringTest() => isProperty<string>();
        [TestMethod] public void CurrentFilterTest() => isProperty<string>();
        [TestMethod] public void FixedFilterTest() => isProperty<string>();
        [TestMethod] public void FixedValueTest() => isProperty<string>();
        [TestMethod]
        public void SqlQueryTest() {
            var b = repo.createSqlQuery().Expression.ToString();
            isFalse(b.Contains(".Where"));
            repo.SearchString = random<string>();
            b = repo.createSqlQuery().Expression.ToString();
            isTrue(b.Contains(".Where"));
        }
    }
}