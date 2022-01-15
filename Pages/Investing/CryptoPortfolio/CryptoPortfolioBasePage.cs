using BankingApp.Data.Investing;
using BankingApp.Data.Misc;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
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
    public abstract class CryptoPortfolioBasePage<TPage> :
        ViewPage<TPage, ICryptoPortfolioRepository, CryptoPortfolio, CryptoPortfolioView, CryptoPortfolioData>
        where TPage : PageModel
    {

        protected CryptoPortfolioBasePage(ICryptoPortfolioRepository r) : base(r, "CryptoPortfolio")
        {
        }
        protected internal override CryptoPortfolio toObject(CryptoPortfolioView v) => new CryptoPortfolioViewFactory().Create(v);
        protected internal override CryptoPortfolioView toView(CryptoPortfolio o) => new CryptoPortfolioViewFactory().Create(o);
        protected internal override Uri pageUrl() => new Uri("/Manager/CryptoPortfolios", UriKind.Relative);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.CustomerID);
            createColumn(x => Item.CustomerName);
            createColumn(x => Item.CryptoName);
            createColumn(x => Item.BlockChain);
            createColumn(x => Item.Ticker);
            createColumn(x => Item.UnitPrice);
            createColumn(x => Item.Units);
            createColumn(x => Item.TotalPrice);
            //createColumn(x => Item.AmountToSell);
        }
        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            6 or 8 => getName<decimal>(h, i),
            7 => getName<int>(h, i),
            _ => base.GetName(h, i)
        };
        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            6 or 8 => getValue<decimal>(h, i),
            7 => getValue<int>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
