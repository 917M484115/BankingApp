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
        protected override string expectedUrl => "/Client/Products";

        protected override List<string> expectedIndexPageColumns
            => new() { "Name", "Description", "Price", "PictureUri", "CatalogId", "BrandId" };
        protected override void validateValue(string actual, string expected)
        {
            if (expected == "PictureUri")
                areEqual("<img src=\"\" alt=\"uu\" style=\"height: 75px\"/>", actual);
            else if (expected == "CatalogId" || expected == "BrandId")
                areEqual("Unspecified", actual);
            else base.validateValue(actual, expected);
        }
        //    public override string BackToMasterDetailPageUrl => $"/Client/{backUrl()}/Index?handler=Index";

        //    private string backUrl() =>
        //        (FixedFilter == GetMember.Name<ProductData>(x => x.CatalogId)) ? "Catalogs" :
        //        (FixedFilter == GetMember.Name<ProductData>(x => x.BrandId)) ? "Brands" :
        //        "Products";
    }
}
