using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class CryptoPortfolioItemViewFactory : AbstractViewFactory<CryptoPortfolioItemData, CryptoPortfolioItem, CryptoPortfolioItemView>
    {
        protected internal override CryptoPortfolioItem toObject(CryptoPortfolioItemData d) => new CryptoPortfolioItem(d);
        public override CryptoPortfolioItemView Create(CryptoPortfolioItem o)
        {
            var v = base.Create(o);
            if (o.Crypto is not null)
            {
                v.CryptoName = o.Crypto.ToString();
                v.Ticker = o.Crypto.Ticker;
                v.BlockChain = o.Crypto.Blockchain;
            }
            v.UnitPrice = o.UnitPrice;
            v.TotalPrice = o.TotalPrice;
            return v;
        }
    }
}
