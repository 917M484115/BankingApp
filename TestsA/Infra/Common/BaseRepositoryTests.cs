using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra.Common {

    [TestClass]
    public class BaseRepositoryTests
        : AbstractRepoTests<BlockChainRepository, BlockChain, BlockChainData> {
        protected override object createObject()
            => new BlockChainRepository(new InMemoryApplicationDbContext().AppDb);

        protected override BlockChain toObject(BlockChainData d) => new(d);

        [TestMethod]
        public override void IsInheritedTest() {
            var b = getBaseClass();
            areEqual(typeof(object), b);
        }
        [TestMethod]
        public void SqlQueryTest() {
            var b = repo.createSqlQuery().Expression.ToString();
            isTrue(b.Contains(".Select"));
        }
    }
}