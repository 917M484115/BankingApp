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
    [TestClass]
    public class CryptoBasketRepositoryTests
        : RepoTests<CryptoBasketRepository, CryptoBasket, CryptoBasketData>
    {
        protected override object createObject()
            => new CryptoBasketRepository(new InMemoryApplicationDbContext().AppDb);

        protected override CryptoBasket toObject(CryptoBasketData d) => new(d);

        [TestMethod]
        public async Task CloseTest()
        {
            var dt1 = DateTime.Now.AddSeconds(-1);
            await repo.Close(item);
            var dt2 = DateTime.Now.AddSeconds(1);
            var d = dbSet.Find(item.Id);
            areEqualProperties(d, item.Data, nameof(item.Data.To));
            isTrue(d.To > dt1);
            isTrue(d.To < dt2);
        }

        [TestMethod]
        public async Task GetLatestForUserTest()
        {
            var buyerId = random<string>();
            for (var i = 0; i < count; i++)
            {
                var d = random<CryptoBasketData>();
                d.CustomerID = buyerId;
                if (i == idx)
                {
                    d.To = null;
                    item = new CryptoBasket(d);
                }
                await repo.Add(new CryptoBasket(d));
            }
            var actual = await repo.GetLatestForUser(buyerId);
            areEqualProperties(item.Data, actual.Data);
        }
    }
}
