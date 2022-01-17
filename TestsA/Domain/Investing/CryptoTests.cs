using BankingApp.Aids.Constants;
using BankingApp.Aids.Random;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Investing{ 
    [TestClass] public class CryptoTests : SealedClassTests<VirtualAssetEntity<CryptoData>> {
        private CryptoData data;
        private IBlockChainsRepository blockchainRepo;
        private BlockChainData blockchainData;
        private Crypto crypto;
        protected override object createObject() => new Crypto(data);
        [TestInitialize] public override void TestInitialize() {
            data = GetRandom.Object<CryptoData>();
            blockchainRepo = MockRepos.BlockChainsRepo(data.BlockChainID, out blockchainData);
            base.TestInitialize();
            crypto = obj as Crypto;
        }
        [TestMethod] public void PriceTest() => isProperty(data.Price);
        [TestMethod] public void TickerTest() => isProperty(data.Ticker);
        [TestMethod] public void BlockChainIDTest() => isProperty(data.BlockChainID);
        [TestMethod] public void BlockChainTest() {
            isNull(crypto.BlockChain);
            GetRepository.SetServiceProvider(new MockServiceProvider(blockchainRepo));
            areEqualProperties(blockchainData, crypto.BlockChain.Data);
        }
    }
}
