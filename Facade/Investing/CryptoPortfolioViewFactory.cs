using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class CryptoPortfolioViewFactory :AbstractViewFactory<CryptoPortfolioData, CryptoPortfolio, CryptoPortfolioView>
    {
        protected internal override CryptoPortfolio toObject(CryptoPortfolioData d) => new CryptoPortfolio(d);
        public override CryptoPortfolioView Create(CryptoPortfolio o)
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
