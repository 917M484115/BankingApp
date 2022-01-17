using BankingApp.Pages.Investing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages.Investing
{
    [TestClass]
    public class  BlockChainsClientPageTests : AuthorizedPageTests<BlockChainsClientPage, BlockChainsBasePage<BlockChainsClientPage>>
    {
        protected override object createObject() => new BlockChainsClientPage(MockRepos.BlockChains());
        //public sealed class CatalogsClientPageTests :CatalogsBasePageTests<CatalogsClientPageTests> {
        //    public CatalogsClientPageTests(ICatalogsRepository r) : base(r) { }
        protected override string expectedUrl => "/Client/Catalogs";
        protected override List<string> expectedIndexPageColumns => new() { "Name" };
        [TestMethod]
        public async Task OnGetDetailsAsyncTest()
        {
            var expectedUrl = $"/Client/Products/Index?handler=Index&fixedFilter=CatalogId&fixedValue={id}";
            var r = await page.OnGetDetailsAsync(id, sortOrder, searchString, pageIndex, fixedFilter, fixedValue);
            var actual = r as RedirectResult;
            isNotNull(actual);
            areEqual(expectedUrl, actual.Url);
        }
    }
}
