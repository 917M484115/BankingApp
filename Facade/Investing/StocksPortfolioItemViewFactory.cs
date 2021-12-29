using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class StocksPortfolioItemViewFactory : AbstractViewFactory<StocksPortfolioItemData,StocksPortfolioItem,StocksPortfolioItemView>
    {
        protected internal override StocksPortfolioItem toObject(StocksPortfolioItemData d) => new StocksPortfolioItem(d);
        public override StocksPortfolioItemView Create(StocksPortfolioItem o)
        {
            var v = base.Create(o);
            if(o.Stock is not null)
            {
               v.StockName =o.Stock.ToString();
               v.Ticker = o.Stock.Ticker;
               v.Country = o.Stock.Country;
            }
            v.UnitPrice =o.UnitPrice;
            v.TotalPrice = o.TotalPrice;
            return v;
        }
    }
}
