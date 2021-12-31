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

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoClientPage : CryptoBasePage<CryptoClientPage>
    {
        public CryptoClientPage(ICryptoRepository r,
           ICryptoBasketsRepository cbr, ICryptoBasketItemsRepository cir)
           : base(r, cbr, cir) { }
        protected internal override Uri pageUrl() => new Uri("/Customer/Crypto", UriKind.Relative);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Name);
            createColumn(x => Item.Ticker);
            createColumn(x => Item.Blockchain);
            createColumn(x => Item.Price);
        }
        public override string GetName(IHtmlHelper<CryptoClientPage> h, int i) => i switch
        {
            3 => getName<decimal>(h, i),
            _ => getName<string>(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<CryptoClientPage> h, int i) => i switch
        {
            3 => getValue<decimal>(h, i),
            _ => getValue<string>(h, i)
        };
        public override string BackToMasterDetailPageUrl => $"/Customer/Index?handler=Index";
    }
}
