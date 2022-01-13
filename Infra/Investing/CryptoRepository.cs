using BankingApp.Infra.Common;
using BankingApp.Infra;
using BankingApp.Domain.Investing;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Infra.Investing
{
    public sealed class CryptoRepository : UniqueEntitiesRepository<Crypto, CryptoData>, ICryptoRepository
    {
        public CryptoRepository(ApplicationDbContext c) : base(c, c.Crypto) { }

        protected internal override Crypto toDomainObject(CryptoData d)=> new Crypto(d);
    }
}
