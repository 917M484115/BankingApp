using BankingApp.Pages.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Pages.Investing.CryptoBaskets
{
    [TestClass]
    public class CryptoBasketsManagerPageTests : AuthorizedPageTests<CryptoBasketsManagerPage, CryptoBasketsBasePage<CryptoBasketsManagerPage>>
    {
        protected override object createObject()
            => new CryptoBasketsManagerPage(
                MockRepos.CryptoBaskets(), MockRepos.Customers()
                , MockRepos.Orders(), MockRepos.OrderItems(),MockRepos.CryptoBasketItems(), MockRepos.Portfolios());

        //    [Authorize]
        //public class BasketsPageTests :ViewPage<BasketsPageTests, IBasketsRepository, Basket, BasketView, BasketData> {
        //    public IEnumerable<SelectListItem> Buyers { get; }
        //    public BasketsPageTests(IBasketsRepository r, IBuyersRepository b) : base(r, "Baskets") {
        //        Buyers = newItemsList<Buyer, BuyerData>(b);
        //    }
        //    public string BuyerName(string id) => itemName(Buyers, id);
        protected override string expectedUrl => "/Shop/Baskets";

        //    protected internal override Basket toObject(BasketView v) => new BasketViewFactory().Create(v);
        //    protected internal override BasketView toView(Basket o) => new BasketViewFactory().Create(o);
        protected override List<string> expectedIndexPageColumns
            => new() { "Id", "BuyerId", "BuyerName", "BuyerAddress", "TotalPrice", "From", "To" };

        //    public override IHtmlContent GetValue(IHtmlHelper<BasketsPageTests> h, int i) => i switch {
        //        4 => getValue<decimal>(h, i),
        //        5 or 6 => getValue<DateTime?>(h, i),
        //        _ => base.GetValue(h, i)
        //    };
    }
}
