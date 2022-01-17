using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Tests.Facade.Investing
{
    [TestClass]
    public class CryptoBasketItemViewFactoryTests : FactoryBaseTests<CryptoBasketItemViewFactory, CryptoBasketItemData, CryptoBasketItem, CryptoBasketItemView>
    {
        protected override string[] excludeProperties => new string[] { "UnitPrice", "ProductName", "TotalPrice", "PictureUri" };
        protected override CryptoBasketItem createObject(CryptoBasketItemData d) => new(d);
        protected override void doBeforeCreateViewTest(CryptoBasketItemData d)
        {
            var r = MockRepos.CryptoRepo(d.CryptoID, out _);
            GetRepository.SetServiceProvider(new MockServiceProvider(r));
        }
        protected override void doAfterCreateViewTest(CryptoBasketItem o, CryptoBasketItemView v)
        {
            areEqual(o.Crypto.ToString(), v.CryptoName);
            areEqual(o.UnitPrice, v.UnitPrice);
            areEqual(o.TotalPrice, v.TotalPrice);
        }
    }
}
