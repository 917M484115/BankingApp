using BankingApp.Domain.Common;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing.Repositories
{
    public interface IStocksBasketsRepository : IRepository<StocksBasket>
    {
        Task<StocksBasket> GetLatestForUser (string name);
        Task Close(StocksBasket p);
    }
}
