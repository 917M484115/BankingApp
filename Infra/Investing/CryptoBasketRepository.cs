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
    public sealed class  CryptoBasketRepository :
        UniqueEntitiesRepository<CryptoBasket, CryptoBasketData>, ICryptoBasketsRepository
    {
        public CryptoBasketRepository(ApplicationDbContext c) : base(c, c.CryptoBaskets) { }
        public async Task Close(CryptoBasket p)
        {
            var d = p?.Data;
            if(d==null) return;
            d.To =DateTime.Now;
            await Update(new CryptoBasket(d));
        }
        public async Task<CryptoBasket> GetLatestForUser(string name)
        {
            var l = await dbSet
                .Where(x => x.CustomerID == name && x.To == null)
                .OrderByDescending(x => x.From)
                .ToListAsync();
            if (l.Count > 0) return toDomainObject(l[0]);
            var d = new CryptoBasketData { CustomerID = name, From = DateTime.Now };
            var o = new CryptoBasket(d);
            await Add(o);
            return o;
        }

        protected internal override CryptoBasket toDomainObject(CryptoBasketData d) => new CryptoBasket(d);
    }
}
