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
    public class CryptoBasketItemsManagerPageTests : AuthorizedPageTests<CryptoBasketItemsManagerPage, CryptoBasketItemsBasePage<CryptoBasketItemsManagerPage>>
    {
        protected override object createObject()
            => new CryptoBasketItemsManagerPage(
                MockRepos.CryptoBasketItems(), MockRepos.CryptoBaskets(), MockRepos.Cryptos(),MockRepos.BlockChains());


        protected override string expectedUrl => "/Manager/CryptoBasketItems";

        //    protected internal override BasketItem toObject(BasketItemView v) => new BasketItemViewFactory().Create(v);
        //    protected internal override BasketItemView toView(BasketItem o) => new BasketItemViewFactory().Create(o);
        protected override List<string> expectedIndexPageColumns
            => new() { "Id", "BasketId", "ProductId", "ProductName", "UnitPrice", "Quantity", "TotalPrice", "From", "To" };
        //    public override string BackToMasterDetailPageUrl => $"/Shop/Baskets/Details" +
        //                   "?handler=Details" +
        //                   $"&id={FixedValue}";
    }
}
