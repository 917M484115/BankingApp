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
    public class CryptoBasketViewFactoryTests : FactoryBaseTests<CryptoBasketViewFactory, CryptoBasketData, CryptoBasket, CryptoBasketView>
    {
        protected override string[] excludeProperties => new string[] { "CustomerName", "CustomerAddress", "Closed", "TotalPrice" };
        protected override void doBeforeCreateViewTest(CryptoBasketData d)
        {
            var r = MockRepos.Customers(d.CustomerID, out _);
            GetRepository.SetServiceProvider(new MockServiceProvider(r));
        }
        protected override void doAfterCreateViewTest(CryptoBasket o, CryptoBasketView v)
        {
            areEqual(o.Customer.Name, v.CustomerName);
            areEqual(o.Customer.Country, v.CustomerCountry);
            areEqual(o.Data.To is not null, v.Closed);
            areEqual(o.TotalPrice, v.TotalPrice);
        }
        protected override CryptoBasket createObject(CryptoBasketData d) => new(d);
    }
}
