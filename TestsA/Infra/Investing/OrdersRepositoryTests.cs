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
    public class OrdersRepositoryTests
        : RepoTests<OrdersRepository, Order, OrderData>
    {
        protected override object createObject()
            => new OrdersRepository(new InMemoryApplicationDbContext().AppDb);

        protected override Order toObject(OrderData d) => new(d);


        [TestMethod]
        public async Task GetLatestForUserTest()
        {
            var buyerId = random<string>();
            for (var i = 0; i < count; i++)
            {
                var d = random<OrderData>();
                d.CustomerID = buyerId;
                if (i == idx)
                {
                    d.To = null;
                    item = new Order(d);
                }
                await repo.Add(new Order(d));
            }
            var actual = await repo.GetLatestForUser(buyerId);
            areEqualProperties(item.Data, actual.Data);
        }
    }
}
