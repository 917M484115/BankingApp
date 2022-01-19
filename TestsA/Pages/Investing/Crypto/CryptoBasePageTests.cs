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
        protected override string expectedUrl => "/Manager/Crypto";
        [TestMethod] public async Task BlockChainNameTest() => await selectNameTest(blockchains, x => page.BlockChainName(x));
        
        [TestMethod] public void OnGetSelectAsyncTest() => notTested();
        [TestMethod] public async Task BlockChainsTest() => await selectListTest(page.BlockChains, blockchains);
       
        [TestMethod] public void CryptoBasketsTest() => notTested();
        [TestMethod] public void CryptoBasketItemsTest() => notTested();
        [TestMethod] public void BackToMasterDetailPageUrlTest() => notTested();

       
        //protected internal override ProductView toView(Product o) => new ProductViewFactory().Create(o);
        protected override List<string> expectedIndexPageColumns => new()
        {
            "Id",
            "Name",
            "Ticker",
            "BlockChainID",
            "Price"
        };
        
       
    }
}
