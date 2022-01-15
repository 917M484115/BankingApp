using BankingApp.Domain.Investing.Repositories;
namespace BankingApp.Pages.Investing
{
    public sealed class BlockChainsManagerPage : BlockChainsBasePage<BlockChainsManagerPage>
    {
        public BlockChainsManagerPage(IBlockChainsRepository r) : base(r) { }
    }
}
