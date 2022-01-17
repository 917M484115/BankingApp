using BankingApp.Aids.Random;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Common
{
    [TestClass]
    public class GetFromTests: SealedClassTests<object>
    {
        protected override object createObject() => new GetFrom<IBlockChainsRepository, BlockChain>();

        private string id;
        private IBlockChainsRepository blockchainsRepo;
        private MockServiceProvider provider;
        private BlockChainData blockchainData;

        [TestInitialize] public override void TestInitialize() {
            type = typeof(GetRepository);
            id = GetRandom.String();
            blockchainsRepo = MockRepos.BlockChainsRepo(id, out blockchainData);
            provider = new MockServiceProvider(blockchainsRepo);
            GetRepository.SetServiceProvider(provider);
            base.TestInitialize();
        }
        [TestMethod] public void ByIdTest() {
            var o = new GetFrom<IBlockChainsRepository, BlockChain>().ById(id);
            areEqualProperties(blockchainData, o.Data);
        }
        [TestMethod] public void ListByTest()
        {
            var l = new GetFrom<IBlockChainsRepository, BlockChain>().ListBy( nameof(blockchainData.Code), blockchainData.Code);;
            areEqual(1, l.Count);
            areEqualProperties(blockchainData, l[0].Data);
        }
        [TestMethod] public void ListBySearchStringTest()
        {
            var l = new GetFrom<IBlockChainsRepository, BlockChain>().ListBy(null, null, null);
            areEqual(blockchainsRepo.Get().GetAwaiter().GetResult().Count, l.Count);
        }
    }
}
