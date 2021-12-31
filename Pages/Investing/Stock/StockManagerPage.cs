using System;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class StockManagerPage : StockBasePage<StockManagerPage>
    {
        public StockManagerPage(IStockRepository r) : base(r) { }

        protected internal override Uri pageUrl() => new Uri("/InvestingManager/Stock", UriKind.Relative);

    }
}