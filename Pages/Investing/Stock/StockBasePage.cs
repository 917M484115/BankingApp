using BankingApp.Pages.Common;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using BankingApp.Data.Investing;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using BankingApp.Infra;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankingApp.Domain.Investing.Repositories;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BankingApp.Pages.Investing
{
    public abstract class StockBasePage<TPage> :
        ViewPage<TPage, IStockRepository, Stock, StockView, StockData>
        where TPage : PageModel
    {
        protected StockBasePage(IStockRepository r) : base(r, "Stock")
        {
        }
        protected internal override Uri pageUrl() => new Uri("/Investing/Stock", UriKind.Relative);
        protected internal override Stock toObject(StockView v) => new StockViewFactory().Create(v);
        protected internal override StockView toView(Stock o) => new StockViewFactory().Create(o);

        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Name);
            createColumn(x => Item.Ticker);
            createColumn(x => Item.Country);
            createColumn(x => Item.Price);

        }
        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 => getName<double>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            4 => getValue<double>(h, i),
            _ => base.GetValue(h, i)
        };

    }
}
