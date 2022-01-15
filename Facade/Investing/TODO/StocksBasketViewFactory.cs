using BankingApp.Data.Investing;
using BankingApp.Facade.Common;
using BankingApp.Domain.Investing;
using BankingApp.Data.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class StocksBasketViewFactory : AbstractViewFactory<StocksBasketData, StocksBasket, StocksBasketView>
    {
        protected internal override StocksBasket toObject(StocksBasketData d) => new StocksBasket(d);
        public override StocksBasketView Create(StocksBasket o)
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
