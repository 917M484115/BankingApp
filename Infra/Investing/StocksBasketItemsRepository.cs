using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using System.Threading.Tasks;
using BankingApp.Data.Investing;

namespace BankingApp.Infra.Investing
{
    public sealed class StocksBasketItemsRepository :
        UniqueEntitiesRepository<StocksBasketItem, StocksBasketItemData>, IStocksBasketItemsRepository
    {
        public StocksBasketItemsRepository(ApplicationDbContext c) : base(c, c.StocksBasketItems) { }
        protected internal override StocksBasketItem toDomainObject(StocksBasketItemData d) => new(d);
        public async Task<StocksBasketItem> Add(StocksBasket p, Stock s)
        {
            StocksBasketItemData d = new()
            {
                StocksBasketID = p.Id,
                StockID = s.Id,
                Quantity = 1
            };
            var o = toDomainObject(d);
            await Add(o);
            return o;
        }
    }
}
