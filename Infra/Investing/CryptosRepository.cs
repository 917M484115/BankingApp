using BankingApp.Infra.Common;
using BankingApp.Domain.Investing;
using BankingApp.Data.Investing;
namespace BankingApp.Infra.Investing
{
    public sealed class CryptosRepository : UniqueEntitiesRepository<Crypto, CryptoData>
    {
        public CryptosRepository(ApplicationDbContext c) : base(c, c.Crypto) { }

        protected internal override Crypto toDomainObject(CryptoData d)=> new Crypto(d);
    }
}
