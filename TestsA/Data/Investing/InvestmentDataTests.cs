using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Investing
{
    [TestClass]
    public class InvestmentDataTests : SealedClassTests<MoneyAmountData>
    {
        [TestMethod] public void CurrentAmountTest() => isProperty<double>();
        [TestMethod] public void DescriptionTest() => isProperty<string>();
    }
}
