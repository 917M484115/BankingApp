using BankingApp.Domain.Common;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing.Repositories
{
    public interface IOrdersRepository : IRepository<Order>
    {
        Task<Order> GetLatestForUser(string name);
    }
}
