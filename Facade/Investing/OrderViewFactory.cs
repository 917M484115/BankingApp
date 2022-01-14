using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
    public sealed class OrderViewFactory : AbstractViewFactory<OrderData,Order,OrderView>
    {
        protected internal override Order toObject(OrderData d) => new Order(d);
        public override OrderView Create(Order o)
        {
            var v = base.Create(o);
            if (o.Customer is not null)
            {
                v.CustomerName = o.Customer.Name;
            }
            v.TotalPrice = o.TotalPrice;
            v.Closed = o?.Data?.To != null;
            return v;
        }
    }
}
