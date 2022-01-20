using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Infra.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra.Misc
{
    [TestClass]
    public class BankRepositoryTests : RepoTests<BankRepository, Bank, BankData>
    {
        protected override object createObject()
            => new BankRepository(new InMemoryApplicationDbContext().AppDb);
        protected override Bank toObject(BankData d) => new(d);
    }
}
