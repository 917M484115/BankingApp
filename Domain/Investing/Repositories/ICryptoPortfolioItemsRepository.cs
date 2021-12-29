using BankingApp.Domain.Common;
using System.Threading.Tasks;
namespace BankingApp.Domain.Investing.Repositories
{
    public interface ICryptoPortfolioItemsRepository : IRepository<CryptoPortfolioItem>
    {
        Task<CryptoPortfolioItem> Add(CryptoPortfolio p, Crypto c);
    }
}
