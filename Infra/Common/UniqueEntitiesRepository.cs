using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BankingApp.Infra.Common
{

    public abstract class UniqueEntitiesRepository<TDomain, TData> :PaginatedRepository<TDomain, TData>
        where TDomain : IEntity<TData>
        where TData : UniqueEntityData, new() {

        protected UniqueEntitiesRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        protected override async Task<TData> getData(string id)
            => await dbSet.FirstOrDefaultAsync(m => m.Id == id);

        protected override TData getDataById(TData d) => dbSet.Find(d.Id);

    }

}
