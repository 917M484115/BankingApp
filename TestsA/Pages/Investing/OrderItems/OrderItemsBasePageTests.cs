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

namespace BankingApp.Tests.Pages.Investing.OrderItems
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
        protected override string expectedUrl => "/Shop/OrderItems";
        [TestMethod] public async Task OrderNameTest() => await selectNameTest(orders, page.OrderName);
        [TestMethod] public async Task ProductNameTest() => await selectNameTest(cryptos, page.CryptoName);
        [TestMethod] public async Task OrdersTest() => await selectListTest(page.Orders, orders);
        [TestMethod] public async Task ProductsTest() => await selectListTest(page.Crypto, cryptos);
        [TestMethod] public void BackToMasterDetailPageUrlTest() => notTested();

       
        protected override List<string> expectedIndexPageColumns => new()
        {
            "Id",
            "OrderId",
            "ProductId",
            "ProductName",
            "PictureUri",
            "UnitPrice",
            "Units",
            "TotalPrice",
            "From",
            "To"
        };
        protected override void validateValue(string actual, string expected)
        {
            if (expected == "PictureUri")
                areEqual("<img src=\"\" alt=\"uu\" style=\"height: 75px\"/>", actual);
            else base.validateValue(actual, expected);
        }
        //public override string GetName(IHtmlHelper<TPage> h, int i) => i switch {
        //    5 or 7 => getName<decimal>(h, i),
        //    6 => getName<int>(h, i),
        //    8 or 9 => getName<DateTime?>(h, i),
        //    _ => base.GetName(h, i)
        //};
        //public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch {
        //    4 => h.DisplayImageFor(Item.PictureUri),
        //    5 or 7 => getValue<decimal>(h, i),
        //    6 => getValue<int>(h, i),
        //    8 or 9 => getValue<DateTime?>(h, i),
        //    _ => base.GetValue(h, i)
        //};
    }
}
