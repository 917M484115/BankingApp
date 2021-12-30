using BankingApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Domain.Investing.Repositories
{
    public interface IOrdersRepository : IRepository<Order>
    {
        Task<Order> GetLatestForUser(string name);
        Task Close(Order b);
    }
}
