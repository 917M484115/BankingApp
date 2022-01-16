using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class OrderItemViewFactory : AbstractViewFactory<OrderItemData,OrderItem,OrderItemView> 
    {
        protected internal override OrderItem toObject(OrderItemData d) => new OrderItem(d);
        public override OrderItemView Create(OrderItem o)
        {
            var v = base.Create(o);
            if (o.Crypto is not null)
            {
                v.CryptoName = o.Crypto.Name;
                v.BlockChain = o.Crypto.BlockChainID;
                v.Ticker = o.Crypto.Ticker;
            }
            v.OrderTime = o.OrderTime;
            v.UnitPrice = o.UnitPrice;
            v.TotalPrice = o.TotalPrice;
            return v;
        }
    }
}
