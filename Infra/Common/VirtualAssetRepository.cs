using BankingApp.Data.Common;
using BankingApp.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BankingApp.Infra.Common
{
    public abstract class VirtualAssetRepository<TDomain, TData> : UniqueEntitiesRepository<TDomain, TData>
        where TDomain : IEntity<TData>
        where TData : VirtualAssetData, new()

    {
        protected VirtualAssetRepository(DbContext c, DbSet<TData> s) : base(c, s) { }
        
    }
}
