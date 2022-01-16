using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Common;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Infra.Investing
{
    public sealed class BlockChainRepository:UniqueEntitiesRepository<BlockChain,BlockChainData>,IBlockChainsRepository
    {
        public BlockChainRepository(ApplicationDbContext c) : base(c, c.BlockChains) { }
        protected internal override BlockChain toDomainObject(BlockChainData d) => new (d);
    }
}
