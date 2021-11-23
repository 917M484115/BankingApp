using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Data.Investing;
namespace BankingApp.Infra.Investing
{
    public sealed class StocksRepository : UniqueEntitiesRepository<Stock, StockData>
    {
        public StocksRepository(ApplicationDbContext c) : base(c, c.Stock) { }
        protected internal override Stock toDomainObject(StockData d) => new Stock(d);
    }
}
