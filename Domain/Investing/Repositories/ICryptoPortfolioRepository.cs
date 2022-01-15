using BankingApp.Domain.Common;
using System.Threading.Tasks;
namespace BankingApp.Domain.Investing.Repositories
{
    public interface ICryptoPortfolioRepository : IRepository<CryptoPortfolio>
    {
        Task AddItems(CryptoBasket b,string id);
    }
}
