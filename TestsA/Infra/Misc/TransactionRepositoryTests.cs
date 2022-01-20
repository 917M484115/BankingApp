using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Infra.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra.Misc
{
    [TestClass]
    public class TransactionRepositoryTests : RepoTests<TransactionRepository, Transaction, TransactionData>
    {
        protected override object createObject()
            => new TransactionRepository(new InMemoryApplicationDbContext().AppDb);
        protected override Transaction toObject(TransactionData d) => new(d);
    }
}
