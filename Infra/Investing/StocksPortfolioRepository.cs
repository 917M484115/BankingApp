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
    public sealed class StocksPortfolioRepository :
        UniqueEntitiesRepository<StocksPortfolio, StocksPortfolioData>, IStocksPortfoliosRepository
    {
        public StocksPortfolioRepository(ApplicationDbContext c) : base(c, c.StocksPortfolios) { }
        public async Task Close(StocksPortfolio p)
        {
            var d = p?.Data;
            if (d == null) return;
            d.To = DateTime.Now;
            await Update(new StocksPortfolio(d));
        }
        public async Task<StocksPortfolio> GetLatestForUser(string name)
        {
            var l = await dbSet
                .Where(x => x.CustomerID == name && x.To == null)
                .OrderByDescending(x => x.From)
                .ToListAsync();
            if (l.Count > 0) return toDomainObject(l[0]);
            var d = new StocksPortfolioData { CustomerID = name, From = DateTime.Now };
            var o = new StocksPortfolio(d);
            await Add(o);
            return o;
        }

        protected internal override StocksPortfolio toDomainObject(StocksPortfolioData d) => new StocksPortfolio(d);
    }
}
