using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using BankingApp.Pages.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages.Investing
{
    [TestClass]
    public class OrderItemsBasePageTests : CommonPageTests<OrderItemsManagerPage, ViewPage<OrderItemsManagerPage,
        IOrderItemsRepository, OrderItem, OrderItemView, OrderItemData>>
    {
        private IOrdersRepository orders;
        private ICryptoRepository cryptos;
        protected override object createObject()
        {
            orders = addItems<Order, OrderData>(MockRepos.Orders(), d => new Order(d)) as IOrdersRepository;
            cryptos = addItems<Crypto, CryptoData>(MockRepos.Cryptos(), d => new Crypto(d)) as ICryptoRepository;
            return new OrderItemsManagerPage(MockRepos.OrderItems(), orders, cryptos);
        }
        protected override string expectedUrl => "/Manager/OrderItems";
        [TestMethod] public async Task OrderNameTest() => await selectNameTest(orders, page.OrderName);
        [TestMethod] public async Task CryptoNameTest() => await selectNameTest(cryptos, page.CryptoName);
        [TestMethod] public async Task OrdersTest() => await selectListTest(page.Orders, orders);
        [TestMethod] public async Task CryptosTest() => await selectListTest(page.Crypto, cryptos);
        [TestMethod] public void BackToMasterDetailPageUrlTest() => notTested();

       
        protected override List<string> expectedIndexPageColumns => new()
        {
            "OrderType",
            "Id",
            "OrderID",
            "CryptoID",
            "CryptoName",
            "UnitPrice",
            "Units",
            "TotalPrice",
            "OrderTime"
        };
       
    }
}
