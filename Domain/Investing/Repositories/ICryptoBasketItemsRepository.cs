using BankingApp.Domain.Common;
using System.Threading.Tasks;
namespace BankingApp.Domain.Investing.Repositories
{
    public interface ICryptoBasketItemsRepository : IRepository<CryptoBasketItem>
    {
        Task<CryptoBasketItem> Add(CryptoBasket p, Crypto c);
        Task Delete(CryptoBasket p, CryptoBasketItem c);
    }
}
