using BankingApp.Domain.Common;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing.Repositories
{
    public interface IStocksPortfoliosRepository : IRepository<StocksPortfolio>
    {
        Task<StocksPortfolio> GetLatestForUser (string name);
        Task Close(StocksPortfolio p);
    }
}
