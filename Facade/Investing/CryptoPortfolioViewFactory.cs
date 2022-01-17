using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class CryptoPortfolioViewFactory : AbstractViewFactory<CryptoPortfolioData,CryptoPortfolio,CryptoPortfolioView>
    {
        protected internal override CryptoPortfolio toObject(CryptoPortfolioData d) => new CryptoPortfolio(d);
        public override CryptoPortfolioView Create(CryptoPortfolio o)
        {
            var v = base.Create(o);
            if (o.Crypto is not null)
            {
                v.CryptoName = o.Crypto.Name;
                v.BlockChain = o.Crypto.BlockChain.Data.Name;
                v.Ticker = o.Crypto.Ticker;
                v.CustomerName =o.Customer.Name;
                v.Units =o.Units;
            }
            v.CustomerID = o.CustomerID;
            v.UnitPrice = o.UnitPrice;
            v.TotalPrice = o.TotalPrice;
            return v;
        }
    }
}
