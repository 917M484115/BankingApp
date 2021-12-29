using BankingApp.Data.Investing;
using BankingApp.Facade.Common;
using BankingApp.Domain.Investing;
using BankingApp.Data.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class StocksPortfolioViewFactory : AbstractViewFactory<StocksPortfolioData, StocksPortfolio, StocksPortfolioView>
    {
        protected internal override StocksPortfolio toObject(StocksPortfolioData d) => new StocksPortfolio(d);
        public override StocksPortfolioView Create(StocksPortfolio o)
        {
            var v = base.Create(o);
            v.CustomerName = o?.Customer?.Name;
            v.CustomerCountry = o?.Customer?.Country;
            v.Closed = o?.Data?.To != null;
            v.TotalPrice = o?.TotalPrice ?? BaseEntity.UnspecifiedDecimal;
            return v;
        }
    }
}
