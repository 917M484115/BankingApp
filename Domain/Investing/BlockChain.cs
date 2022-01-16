using BankingApp.Data.Investing;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Investing
{
    public sealed class BlockChain : NamedEntity<BlockChainData>
    {
        public BlockChain(BlockChainData d) : base(d) { }
    }
}
