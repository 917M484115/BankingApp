using BankingApp.Domain.Common;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing.Repositories
{
    public interface ICryptoBasketsRepository : IRepository<CryptoBasket>
    {
        Task<CryptoBasket> GetLatestForUser(string name);
        Task Close(CryptoBasket b);
    }
}
