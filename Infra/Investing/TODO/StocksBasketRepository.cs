using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using System.Threading.Tasks;
using BankingApp.Data.Investing;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Infra.Investing
{
    public sealed class StocksBasketRepository :
        UniqueEntitiesRepository<StocksBasket, StocksBasketData>, IStocksBasketsRepository
    {
        public StocksBasketRepository(ApplicationDbContext c) : base(c, c.StocksBaskets) { }
        public async Task Close(StocksBasket p)
        {
            var d = p?.Data;
            if (d == null) return;
            d.To = DateTime.Now;
            await Update(new StocksBasket(d));
        }
        public async Task<StocksBasket> GetLatestForUser(string name)
        {
            var l = await dbSet
                .Where(x => x.CustomerID == name && x.To == null)
                .OrderByDescending(x => x.From)
                .ToListAsync();
            if (l.Count > 0) return toDomainObject(l[0]);
            var d = new StocksBasketData { CustomerID = name, From = DateTime.Now };
            var o = new StocksBasket(d);
            await Add(o);
            return o;
        }

        protected internal override StocksBasket toDomainObject(StocksBasketData d) => new StocksBasket(d);
    }
}
