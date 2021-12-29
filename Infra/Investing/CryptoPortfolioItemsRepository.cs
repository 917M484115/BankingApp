using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using System.Threading.Tasks;
using BankingApp.Data.Investing;

namespace BankingApp.Infra.Investing
{
    public sealed class CryptoPortfolioItemsRepository :
        UniqueEntitiesRepository<CryptoPortfolioItem, CryptoPortfolioItemData>, ICryptoPortfolioItemsRepository
    {
        public CryptoPortfolioItemsRepository(ApplicationDbContext c) : base(c, c.CryptoPortfolioItems) { }
        protected internal override CryptoPortfolioItem toDomainObject(CryptoPortfolioItemData d) => new(d);
        public async Task<CryptoPortfolioItem> Add(CryptoPortfolio p, Crypto c)
        {
            CryptoPortfolioItemData d = new()
            {
                CryptoPortfolioID = p.Id,
                CryptoID = c.Id,
                Quantity = 1
            };
            var o = toDomainObject(d);
            await Add(o);
            return o;
        }
    }
}
