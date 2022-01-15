using BankingApp.Domain.Common;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing.Repositories
{
    public interface ICryptoOrderItemsRepository : IRepository<OrderItem>
    {
        Task AddItems(Order o, CryptoBasket b);
    }
}
