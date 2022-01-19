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
    public class CryptoBasketItemsClientPageTests : AuthorizedPageTests<CryptoBasketItemsClientPage, CryptoBasketItemsBasePage<CryptoBasketItemsClientPage>>
    {
        protected override object createObject()
            => new CryptoBasketItemsClientPage(
                MockRepos.CryptoBasketItems(), MockRepos.CryptoBaskets(), MockRepos.Cryptos(),MockRepos.BlockChains());
        [TestMethod] public void BackToMasterDetailPageUrlTest() => notTested();

        //[Authorize]
        //public sealed class BasketItemsClientPage :BasketItemsBasePage<BasketItemsClientPage> {
        //    public BasketItemsClientPage(IBasketItemsRepository r, IBasketsRepository b, IProductsRepository p)
        //        : base(r, b, p) {}
        protected override string expectedUrl => "/Customer/CryptoBasketItems";


        //    public override string BackToMasterDetailPageUrl => $"/Client/Baskets/Index?handler=Index";

        protected override List<string> expectedIndexPageColumns
            => new() { "CryptoName", "Ticker", "UnitPrice", "Quantity", "TotalPrice" };
    }
}
