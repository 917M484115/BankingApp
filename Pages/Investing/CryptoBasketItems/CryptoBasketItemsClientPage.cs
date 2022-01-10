using BankingApp.Data.Investing;
using BankingApp.Data.Misc;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BankingApp.Pages.Investing
{
    public sealed class CryptoBasketItemsClientPage : CryptoBasketItemsBasePage<CryptoBasketItemsClientPage>
    {
        public CryptoBasketItemsClientPage(ICryptoBasketItemsRepository cbir, ICryptoBasketsRepository cbr, ICryptoRepository cr)
                    : base(cbir, cbr, cr) { }
        protected internal override Uri pageUrl() => new Uri("/Customer/CryptoBasketItems", UriKind.Relative);
        public override string BackToMasterDetailPageUrl => $"/Customer/CryptoBaskets/Index?handler=Index";
        protected override void createTableColumns()
        {
            createColumn(x => Item.CryptoName);
            createColumn(x => Item.Ticker);
            createColumn(x => Item.BlockChain);
            createColumn(x => Item.UnitPrice);
            createColumn(x => Item.Quantity);
            createColumn(x => Item.TotalPrice);
        }
        public override string GetName(IHtmlHelper<CryptoBasketItemsClientPage> h, int i) => i switch
        {
            3 or 5 => getName<decimal>(h, i),
            4 => getName<int>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<CryptoBasketItemsClientPage> h, int i) => i switch
        {
            3 or 5 => getValue<decimal>(h, i),
            4 => getValue<int>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
