using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class BlockChainViewFactory:AbstractViewFactory<BlockChainData,BlockChain,BlockChainView>
    {
        protected internal override BlockChain toObject(BlockChainData d)=>new BlockChain(d);
    }
}
