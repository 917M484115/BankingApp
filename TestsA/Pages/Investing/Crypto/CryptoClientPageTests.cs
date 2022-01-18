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
    public class CryptoClientPageTests : AuthorizedPageTests<CryptoClientPage, CryptoBasePage<CryptoClientPage>>
    {
        protected override object createObject()
            => new CryptoClientPage(MockRepos.Cryptos(),MockRepos.CryptoBaskets(), MockRepos.CryptoBasketItems(), MockRepos.BlockChains());
        [TestMethod] public void BackToMasterDetailPageUrlTest() => notTested();

        //    [Authorize]
        //public sealed class ProductsClientPageTests : ProductsBasePageTests<ProductsClientPageTests> {
        //    public ProductsClientPageTests(IProductsRepository r, ICatalogsRepository c, IBrandsRepository b,
        //        IBasketsRepository ba, IBasketItemsRepository bi)
        //        : base(r, c, b, ba, bi) {}
        protected override string expectedUrl => "/Customer/Crypto";

        protected override List<string> expectedIndexPageColumns
            => new()
            {
                
                "Name",
                "Ticker",
                "BlockChainID",
                "Price"
            };
        
    }
}
