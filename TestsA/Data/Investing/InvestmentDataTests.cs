using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Investing
{
    [TestClass]
    public class InvestmentDataTests : SealedClassTests<InvestmentData, MoneyAmountData>
    {
        [TestMethod] public void CurrentAmountTest() => isReadWriteProperty<double>();
        [TestMethod] public void DescriptionTest() => isReadWriteProperty<string>();
    }
}
