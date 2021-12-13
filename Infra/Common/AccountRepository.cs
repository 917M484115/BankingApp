using System.Threading.Tasks;
using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Infra.Common
{
    public abstract class AccountRepository<TDomain, TData> : MoneyAmountRepository<TDomain, TData>
        where TDomain : IEntity<TData>
        where TData : MoneyAmountData, new()

    {
        protected AccountRepository(DbContext c, DbSet<TData> s) : base(c, s) { }
    }
}
