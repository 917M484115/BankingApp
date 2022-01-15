using BankingApp.Domain.Common;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing.Repositories
{
    public interface IStocksBasketItemsRepository :IRepository<StocksBasketItem>
    {
        Task<StocksBasketItem> Add(StocksBasket p, Stock s);
    }
}
