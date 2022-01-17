using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Infra.Investing
{
    [TestClass] public class CryptoRepositoryTests : RepoTests<CryptoRepository, Crypto, CryptoData>
    {
        protected override object createObject()
            => new CryptoRepository(new InMemoryApplicationDbContext().AppDb);
        protected override Crypto toObject(CryptoData d) => new(d);
    }
}
