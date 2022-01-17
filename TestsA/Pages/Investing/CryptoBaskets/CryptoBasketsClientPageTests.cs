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
    public class CryptoBasketsClientPageTests : AuthorizedPageTests<CryptoBasketsClientPage, CryptoBasketsBasePage<CryptoBasketsClientPage>>
    {
        protected override object createObject()
            => new CryptoBasketsClientPage(
                MockRepos.CryptoBaskets(), MockRepos.Customers(),
                MockRepos.Orders(), MockRepos.OrderItems(),MockRepos.CryptoBasketItems(),MockRepos.Portfolios());
        [TestMethod] public void OnGetIndexAsyncTest() => notTested();
        [TestMethod] public void OnGetDetailsAsyncTest() => notTested();
        protected override string expectedUrl => "/Client/Baskets";

        //    public override async Task OnGetIndexAsync(string sortOrder,
        //        string id, string currentFilter, string searchString, int? pageIndex,
        //        string fixedFilter, string fixedValue) {
        //        SelectedId = id;
        //        fixedFilter = GetMember.Name<BasketData>(x => x.BuyerId);
        //        fixedValue = User.Identity.Name;
        //        await getList(sortOrder, currentFilter, searchString, pageIndex,
        //            fixedFilter, fixedValue).ConfigureAwait(true);
        //    }
        //    public override async Task<IActionResult> OnGetDetailsAsync(string id, string sortOrder, string searchString,
        //        int pageIndex,
        //        string fixedFilter, string fixedValue) {
        //        var name = GetMember.Name<BasketItemData>(x => x.BasketId);
        //        var page = "/Client/BasketItems";
        //        var url = new Uri($"{page}/Index?handler=Index&fixedFilter={name}&fixedValue={id}",
        //            UriKind.Relative);

        //        await Task.CompletedTask.ConfigureAwait(false);

        //        return Redirect(url.ToString());
        //    }
        protected override List<string> expectedIndexPageColumns
            => new() { "BuyerName", "BuyerAddress", "TotalPrice", "From", "Closed" };
        //    public override string GetName(IHtmlHelper<BasketsClientPageTests> h, int i) => i switch {
        //        2 => getName<decimal>(h, i),
        //        3 => getName<DateTime?>(h, i),
        //        4 => getName<bool>(h, i),
        //        _ => base.GetName(h, i)
        //    };

        //    public override IHtmlContent GetValue(IHtmlHelper<BasketsClientPageTests> h, int i) => i switch {
        //        2 => getValue<decimal>(h, i),
        //        3 => getValue<DateTime?>(h, i),
        //        4 => getValue<bool>(h, i),
        //        _ => base.GetValue(h, i)
        //    };

    }
}
