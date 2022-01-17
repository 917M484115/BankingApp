using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Common;
using BankingApp.Domain.Investing.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace BankingApp.Infra.Investing
{
    public sealed class OrdersRepository : UniqueEntitiesRepository<Order,OrderData>,IOrdersRepository 
    {
        public OrdersRepository(ApplicationDbContext c): base(c, c.Orders) { }
        public async Task<Order> GetLatestForUser(string name)
        {
            var l = await dbSet
                .Where(x => x.CustomerID == name && x.To == null)
                .OrderByDescending(x => x.From)
                .ToListAsync();
            if (l.Count > 0) return toDomainObject(l[0]);
            var d = new OrderData { CustomerID = name, OrderDate = DateTime.Now };
            var o = new Order(d);
            await Add(o);
            return o;
        }

        protected internal override Order toDomainObject(OrderData d)
            => new Order(d);
    }
}
