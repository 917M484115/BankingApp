using BankingApp.Tests.Pages;
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
using BankingApp.Tests;

namespace BankingApp.Tests.Pages.Investing
{
    [TestClass] public class CryptoBasketItemsBasePageTests : CommonPageTests<CryptoBasketItemsManagerPage,
            ViewPage<CryptoBasketItemsManagerPage, ICryptoBasketItemsRepository, CryptoBasketItem, CryptoBasketItemView, CryptoBasketItemData>>
    {
        private ICryptoBasketsRepository baskets;
        private ICryptoRepository cryptos;
        private IBlockChainsRepository blockchains;
        protected override object createObject()
        {
            baskets = addItems<CryptoBasket, CryptoBasketData>(MockRepos.CryptoBaskets(), d => new CryptoBasket(d)) as ICryptoBasketsRepository;
            cryptos = addItems<Crypto, CryptoData>(MockRepos.Cryptos(), d => new Crypto(d)) as ICryptoRepository;
            blockchains = addItems<BlockChain, BlockChainData>(MockRepos.BlockChains(), d => new BlockChain(d)) as IBlockChainsRepository;
            return new CryptoBasketItemsManagerPage(MockRepos.CryptoBasketItems(), baskets, cryptos,blockchains);
        }
        
        protected override string expectedUrl => "/Manager/CryptoBasketItems";
        [TestMethod] public async Task BasketsNameTest() => await selectNameTest(baskets, page.CryptoBasketsName);
        [TestMethod] public async Task ProductNameTest() => await selectNameTest(cryptos, page.CryptoName);
        [TestMethod] public async Task ProductsTest() => await selectListTest(page.Crypto, cryptos);
        [TestMethod] public async Task BasketsTest() => await selectListTest(page.CryptoBaskets, baskets);
        [TestMethod] public void BackToMasterDetailPageUrlTest() => notTested();

       
        protected override List<string> expectedIndexPageColumns => new()
        {
            "Id",
            "CryptoBasketID",
            "CryptoID",
            //"Crypto",
            "Unit Price",
            "Quantity",
            "From",
            "To",
            "Code",
        };
    }
}
