using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class StocksBasketItemViewFactory : AbstractViewFactory<StocksBasketItemData,StocksBasketItem,StocksBasketItemView>
    {
        protected internal override StocksBasketItem toObject(StocksBasketItemData d) => new StocksBasketItem(d);
        public override StocksBasketItemView Create(StocksBasketItem o)
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
