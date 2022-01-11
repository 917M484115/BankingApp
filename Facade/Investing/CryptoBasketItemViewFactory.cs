using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class CryptoBasketItemViewFactory : AbstractViewFactory<CryptoBasketItemData, CryptoBasketItem, CryptoBasketItemView>
    {
        protected internal override CryptoBasketItem toObject(CryptoBasketItemData d) => new CryptoBasketItem(d);
        public override CryptoBasketItemView Create(CryptoBasketItem o)
        {
            var v = base.Create(o);
            if (o.Crypto is not null)
            {
                v.CryptoName = o.Crypto.ToString();
                v.BlockChain = o.Crypto.Blockchain;
                v.Ticker =o.Crypto.Ticker;
            }
            v.UnitPrice = o.UnitPrice;
            v.TotalPrice = o.TotalPrice;
            return v;
        }
    }
}
