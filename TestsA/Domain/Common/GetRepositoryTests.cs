using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Common {
    [TestClass] public class GetRepositoryTests : BaseTests {
        private ICryptoRepository cryptoRepo;
        private IBlockChainsRepository blockchainsRepo;
        private MockServiceProvider provider;

        [TestInitialize] public void TestInitialize() {
            type = typeof(GetRepository);
            cryptoRepo = MockRepos.Cryptos();
            blockchainsRepo = MockRepos.BlockChains();
            provider = new MockServiceProvider(cryptoRepo, blockchainsRepo);
            GetRepository.SetServiceProvider(null);
        }
        [TestMethod] public void SetServiceProviderTest() {
            isNull(GetRepository.services);
            GetRepository.SetServiceProvider(provider);
            Assert.AreSame(provider, GetRepository.services);
        }
        [TestMethod] public void InstanceTest() {
            GetRepository.SetServiceProvider(provider);
            var r = GetRepository.Instance(typeof(ICryptoRepository));
            Assert.AreSame(r, cryptoRepo);
        }
        [TestMethod] public void InstanceByTypeTest()
        {
            GetRepository.SetServiceProvider(provider);
            var r = GetRepository.Instance<IBlockChainsRepository>();
            Assert.AreSame(r, blockchainsRepo);
        }
    }
}
