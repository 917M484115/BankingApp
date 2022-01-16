using BankingApp.Data.Investing;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Aids.Reflection;

namespace BankingApp.Pages.Investing
{
    public sealed class BlockChainsClientPage : BlockChainsBasePage<BlockChainsClientPage>
    {
        public BlockChainsClientPage(IBlockChainsRepository r):base(r) { }
        protected internal override Uri pageUrl()=> new Uri("/Customer/BlockChains",UriKind.Relative);
        protected override void createTableColumns()
        {
            createColumn(x=>Item.Name);
        }
        public override async Task<IActionResult> OnGetDetailsAsync(string id, string sortOrder, string searchString,
            int pageIndex,
            string fixedFilter, string fixedValue)
        {
            var name = GetMember.Name<CryptoData>(x => x.BlockChainID);
            var page = "/Customer/Crypto";
            var url = new Uri($"{page}/Index?handler=Index&fixedFilter={name}&fixedValue={id}",
                UriKind.Relative);
            await Task.CompletedTask.ConfigureAwait(false);
            return Redirect(url.ToString());
        }
    }
}
