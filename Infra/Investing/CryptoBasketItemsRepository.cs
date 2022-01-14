using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using System.Threading.Tasks;
using BankingApp.Data.Investing;

namespace BankingApp.Infra.Investing
{
    public sealed class CryptoBasketItemsRepository :
        UniqueEntitiesRepository<CryptoBasketItem, CryptoBasketItemData>, ICryptoBasketItemsRepository
    {
        public CryptoBasketItemsRepository(ApplicationDbContext c) : base(c, c.CryptoBasketItems) { }
        protected internal override CryptoBasketItem toDomainObject(CryptoBasketItemData d) => new(d);
        public async Task<CryptoBasketItem> Add(CryptoBasket p, Crypto c)
        {
            CryptoBasketItemData d = new()
            {
                CryptoBasketID = p.Id,
                CryptoID = c.Id,
                Quantity = 1
            };
            var o = toDomainObject(d);
            await Add(o);
            
            return o;
        }
        public async Task Delete(CryptoBasket p, CryptoBasketItem c)
        {
            await Delete2(c);
        }
    }
}
