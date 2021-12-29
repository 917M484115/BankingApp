using BankingApp.Domain.Common;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing.Repositories
{
    public interface IStocksPortfolioItemsRepository :IRepository<StocksPortfolioItem>
    {
        Task<StocksPortfolioItem> Add(StocksPortfolio p, Stock s);
    }
}
