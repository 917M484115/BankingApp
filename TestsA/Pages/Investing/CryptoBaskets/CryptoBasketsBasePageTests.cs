using BankingApp.Data.Investing;
using BankingApp.Data.Misc;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
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
    public class CryptoBasketsBasePageTests : CommonPageTests<CryptoBasketsManagerPage, ViewPage<CryptoBasketsManagerPage,
        ICryptoBasketsRepository, CryptoBasket, CryptoBasketView, CryptoBasketData>>
    {
        private ICustomersRepository customers;
        protected override object createObject()
        {
            customers = addItems<Customer, CustomerData>(MockRepos.Customers(), d => new Customer(d)) as ICustomersRepository;
            return new CryptoBasketsManagerPage(MockRepos.CryptoBaskets(), customers
                , MockRepos.Orders(), MockRepos.OrderItems(), MockRepos.CryptoBasketItems(), MockRepos.Portfolios());
        }
        protected override string expectedUrl => "/Manager/CryptoBaskets";
        [TestMethod] public async Task BuyerNameTest() => await selectNameTest(customers, page.CustomerName);
        [TestMethod] public void OnGetSelectAsyncTest() => notTested();
        [TestMethod] public async Task BuyersTest() => await selectListTest(page.Customers, customers);
        [TestMethod] public void OrdersTest() => notTested();
        [TestMethod] public void OrderItemsTest() => notTested();


        protected override List<string> expectedIndexPageColumns => new()
        {
            "Id",
            "BuyerId",
            "BuyerName",
            "BuyerAddress",
            "TotalPrice",
            "From",
            "To"
        };

    }
}
