using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Infra.Investing
{
    public sealed class StockRepository : VirtualAssetRepository<Stock, StockData>, IStockRepository
    {
        public StockRepository(ApplicationDbContext c) : base(c, c.Stock) { }
        protected internal override Stock toDomainObject(StockData d) => new Stock(d);
    }
}
