using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Infra.Common
{
    public abstract class MoneyAmountRepository<TDomain, TData> : UniqueEntitiesRepository<TDomain, TData>
        where TDomain : IEntity<TData>
        where TData : UniqueEntityData, new()
    {

        protected MoneyAmountRepository(DbContext c, DbSet<TData> s) : base(c, s) { }
    }
}

