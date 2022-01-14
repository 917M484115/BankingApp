using BankingApp.Domain.Common;
using System.Threading.Tasks;


namespace BankingApp.Domain.Investing.Repositories
{
    public interface IOrderItemsRepository : IRepository<OrderItem>
    {
        Task AddItems(Order o, CryptoBasket b);
    }
}
