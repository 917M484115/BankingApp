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
    [TestClass] public class CryptoBasketItemsRepositoryTests : RepoTests<CryptoBasketItemsRepository, CryptoBasketItem, CryptoBasketItemData>
    {
        protected override object createObject()
            => new CryptoBasketItemsRepository(new InMemoryApplicationDbContext().AppDb);

        protected override CryptoBasketItem toObject(CryptoBasketItemData d) => new(d);

        [TestMethod]
        public async Task AddItemTest()
        {
            var b = new CryptoBasket(random<CryptoBasketData>());
            var p = new Crypto(random<CryptoData>());
            var i = await repo.Add(b, p);
            var d = dbSet.Find(i.Id);
            areEqual(b.Id, d.CryptoBasketID);
            areEqual(p.Id, d.CryptoID);
            areEqual(1, d.Quantity);
        }
    }
}
