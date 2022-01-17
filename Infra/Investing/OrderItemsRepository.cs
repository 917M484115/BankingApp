using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Common;
using BankingApp.Domain.Investing.Repositories;
using System.Threading.Tasks;
namespace BankingApp.Infra.Investing
{
    public sealed class OrderItemsRepository : UniqueEntitiesRepository<OrderItem,OrderItemData>, IOrderItemsRepository
    {
        public OrderItemsRepository(ApplicationDbContext c): base(c, c.OrderItems) { }
        public async Task AddItems(Order o, CryptoBasket b)
        {
            foreach (var i in b.Items)
            {
                var d = new OrderItemData
                {
                    OrderID = o.Id,
                    CryptoID = i.CryptoID,
                    Units = i.Quantity,
                    OrderTime = System.DateTime.Now,
                    OrderType = "BUY"
                };
                var orderItem = toDomainObject(d);
                await Add(orderItem);
            }
        }

        public async Task AddOrderItem(string OrderID, int Units,string CryptoID)
        {
            if(Units >0)
            {
                var d = new OrderItemData
                {
                    OrderID = OrderID,
                    CryptoID = CryptoID,
                    Units = Units,
                    OrderTime = System.DateTime.Now,
                    OrderType ="SELL"
                };
                var orderItem = toDomainObject(d);
                await Add(orderItem);
            }
        }
        protected internal override OrderItem toDomainObject(OrderItemData d)
           => new OrderItem(d);
    }
}
