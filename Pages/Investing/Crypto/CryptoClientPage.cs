using BankingApp.Pages.Common;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using BankingApp.Data.Investing;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankingApp.Domain.Investing.Repositories;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BankingApp.Aids.Reflection;

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoClientPage : CryptoBasePage<CryptoClientPage>
    {
        public CryptoClientPage(ICryptoRepository r,
           ICryptoBasketsRepository cbr, ICryptoBasketItemsRepository cir, IBlockChainsRepository bcr)
           : base(r, cbr, cir, bcr) { }
        protected internal override Uri pageUrl() => new Uri("/Customer/Crypto", UriKind.Relative);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Name);
            createColumn(x => Item.Ticker);
            createColumn(x => Item.BlockСhainID);
            createColumn(x => Item.Price);
        }
        public override string GetName(IHtmlHelper<CryptoClientPage> h, int i) => i switch
        {
            3 => getName<decimal>(h, i),
            _ => getName<string>(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<CryptoClientPage> h, int i) => i switch
        {
            2 => getRaw(h, BlockChainName(Item?.BlockСhainID)),
            3 => getValue<decimal>(h, i),
            _ => getValue<string>(h, i)
        };
        public override string BackToMasterDetailPageUrl => $"/Customer/{backUrl()}/Index?handler=Index";
        private string backUrl() =>
            (FixedFilter == GetMember.Name<CryptoData>(x => x.BlockChainID)) ? "BlockChains" :
            "Crypto";
    }
}
