using BankingApp.Domain.Common;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing.Repositories
{
    public interface ICryptoPortfoliosRepository : IRepository<CryptoPortfolio>
    {
        Task<CryptoPortfolio> GetLatestForUser(string name);
        Task Close(CryptoPortfolio b);
    }
}
