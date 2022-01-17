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
    public class CryptoBasePageTests : CommonPageTests<CryptoManagerPage, ViewPage<CryptoManagerPage,
        ICryptoRepository, Crypto, CryptoView, CryptoData>>
    {
        
        private IBlockChainsRepository blockchains;

        protected override object createObject()
        {
      
            blockchains = addItems<BlockChain, BlockChainData>(MockRepos.BlockChains(), d => new BlockChain(d)) as IBlockChainsRepository;
            return new CryptoManagerPage(MockRepos.Cryptos(), MockRepos.CryptoBaskets(), MockRepos.CryptoBasketItems(), blockchains
                );
        }
        protected override string expectedUrl => "/Shop/Products";
        [TestMethod] public async Task CatalogNameTest() => await selectNameTest(blockchains, x => page.BlockChainName(x));
        
        [TestMethod] public void OnGetSelectAsyncTest() => notTested();
        [TestMethod] public async Task CatalogsTest() => await selectListTest(page.BlockChains, blockchains);
       
        [TestMethod] public void BasketsTest() => notTested();
        [TestMethod] public void BasketItemsTest() => notTested();
        [TestMethod] public void BackToMasterDetailPageUrlTest() => notTested();

       
        //protected internal override ProductView toView(Product o) => new ProductViewFactory().Create(o);
        protected override List<string> expectedIndexPageColumns => new()
        {
            "Id",
            "Name",
            "Code",
            "Description",
            "Price",
            "PictureUri",
            "CatalogId",
            "BrandId",
            "From",
            "To"
        };
        protected override void validateValue(string actual, string expected)
        {
            if (expected == "PictureUri")
                areEqual("<img src=\"\" alt=\"uu\" style=\"height: 75px\"/>", actual);
            else if (expected == "CatalogId" || expected == "BrandId")
                areEqual("Unspecified", actual);
            else base.validateValue(actual, expected);
        }
       
    }
}
