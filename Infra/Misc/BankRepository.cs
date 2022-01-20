using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Misc
{
    public sealed class BankRepository :
        UniqueEntitiesRepository<Bank, BankData>, IBankRepository
    {
        public BankRepository(ApplicationDbContext c) : base(c, c.Banks) { }
        protected internal override Bank toDomainObject(BankData d)
            => new Bank(d);
    }
}
