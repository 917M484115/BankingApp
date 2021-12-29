using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using System.Threading.Tasks;
using BankingApp.Data.Investing;

namespace BankingApp.Infra.Investing
{
    public sealed class StocksPortfolioItemsRepository :
        UniqueEntitiesRepository<StocksPortfolioItem, StocksPortfolioItemData>, IStocksPortfolioItemsRepository
    {
        public StocksPortfolioItemsRepository(ApplicationDbContext c) : base(c, c.StocksPortfolioItems) { }
        protected internal override StocksPortfolioItem toDomainObject(StocksPortfolioItemData d) => new(d);
        public async Task<StocksPortfolioItem> Add(StocksPortfolio p, Stock s)
        {
            StocksPortfolioItemData d = new()
            {
                StocksPortfolioID = p.Id,
                StockID = s.Id,
                Quantity = 1
            };
            var o = toDomainObject(d);
            await Add(o);
            return o;
        }
    }
}
