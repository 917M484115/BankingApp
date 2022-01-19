using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Infra.Investing;
using BankingApp.Tests;
using BankingApp.Tests.Infra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Infra.Investing { 
    [TestClass]
public class OrderItemsRepositoryTests
        : RepoTests<OrderItemsRepository, OrderItem, OrderItemData>
{
    protected override object createObject()
        => new OrderItemsRepository(new InMemoryApplicationDbContext().AppDb);

    protected override OrderItem toObject(OrderItemData d) => new(d);

    [TestMethod]
    public async Task AddItemsTest()
    {
        var b = new CryptoBasket(random<CryptoBasketData>());
        var biRepo = new CryptoBasketItemsRepository(InvestingDb);
        for (var i = 0; i < count; i++)
        {
            var d = random<CryptoBasketItemData>();
            if (i > idx) d.CryptoBasketID = b.Id;
            await biRepo.Add(new CryptoBasketItem(d));
        }
        var o = new Order(random<OrderData>());
        GetRepository.SetServiceProvider(new MockServiceProvider(repo, biRepo));
        await repo.AddItems(o, b);
        areEqual(b.Items.Count, o.Items.Count);
        var itemsCount = b.Items.Count;
        foreach (var bi in b.Items)
        {
            foreach (var oi in o.Items)
            {
                if (oi.Data.CryptoID != bi.Data.CryptoID) continue;
                areEqual(oi.Units, bi.Quantity);
                itemsCount--;
            }
        }
        areEqual(0, itemsCount);
    }
}
}
