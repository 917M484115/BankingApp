using BankingApp.Pages.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages.Investing
{
    [TestClass] public class CryptoManagerPageTests : AuthorizedPageTests<CryptoManagerPage, CryptoBasePage<CryptoManagerPage>>
    {
        protected override object createObject()
            => new CryptoManagerPage(MockRepos.Cryptos(),
                MockRepos.CryptoBaskets(), MockRepos.CryptoBasketItems(), MockRepos.BlockChains());
        protected override string expectedUrl => "/Shop/Products";
        protected override List<string> expectedIndexPageColumns
            => new() { "Id", "Name", "Code", "Description", "Price", "PictureUri", "CatalogId", "BrandId", "From", "To" };
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
