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
    public sealed class  CryptoPortfolioRepository :
        UniqueEntitiesRepository<CryptoPortfolio, CryptoPortfolioData>, ICryptoPortfoliosRepository
    {
        public CryptoPortfolioRepository(ApplicationDbContext c) : base(c, c.CryptoPortfolios) { }
        public async Task Close(CryptoPortfolio p)
        {
            var d = p?.Data;
            if(d==null) return;
            d.To =DateTime.Now;
            await Update(new CryptoPortfolio(d));
        }
        public async Task<CryptoPortfolio> GetLatestForUser(string name)
        {
            var l = await dbSet
                .Where(x => x.CustomerID == name && x.To == null)
                .OrderByDescending(x => x.From)
                .ToListAsync();
            if (l.Count > 0) return toDomainObject(l[0]);
            var d = new CryptoPortfolioData { CustomerID = name, From = DateTime.Now };
            var o = new CryptoPortfolio(d);
            await Add(o);
            return o;
        }

        protected internal override CryptoPortfolio toDomainObject(CryptoPortfolioData d) => new CryptoPortfolio(d);
    }
}
