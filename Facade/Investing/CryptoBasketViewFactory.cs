using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class CryptoBasketViewFactory :AbstractViewFactory<CryptoBasketData, CryptoBasket, CryptoBasketView>
    {
        protected internal override CryptoBasket toObject(CryptoBasketData d) => new CryptoBasket(d);
        public override CryptoBasketView Create(CryptoBasket o)
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
