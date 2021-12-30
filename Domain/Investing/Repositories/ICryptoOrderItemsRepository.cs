using BankingApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing.Repositories
{
    public interface ICryptoOrderItemsRepository : IRepository<OrderItem>
    {
        Task AddItems(Order o, Crypto b);
    }
}
