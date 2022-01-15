using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
using BankingApp.Infra.Common;
namespace BankingApp.Infra.Misc
{
    public sealed class TransactionRepository :
        UniqueEntitiesRepository<Transaction, TransactionData>, ITransactionRepository
    {
        public TransactionRepository(ApplicationDbContext c) : base(c, c.Transactions) { }
        protected internal override Transaction toDomainObject(TransactionData d)
            => new Transaction(d);
    }
}
