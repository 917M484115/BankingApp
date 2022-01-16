using BankingApp.Domain.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing.Repositories;
namespace BankingApp.Domain.Investing
{
    public sealed class Crypto : VirtualAssetEntity<CryptoData>
    {
        public Crypto(CryptoData d) : base(d){ }
        public string BlockChainID => Data?.BlockChainID ?? Unspecified;
        public BlockChain BlockChain => new GetFrom<IBlockChainsRepository,BlockChain>().ById(BlockChainID);

    }
}
