using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Investing
{
    [TestClass]
    public class CryptoPortfolioDataTests : SealedClassTests<UniqueEntityData>
    {
        [TestMethod] public void CustomerIDTest() => isProperty<string>();
        [TestMethod] public void CryptoIDTest() => isProperty<string>();
        [TestMethod] public void UnitsTest() => isProperty<int>(false);
    }
}
