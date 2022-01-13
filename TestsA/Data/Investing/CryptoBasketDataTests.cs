using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BankingApp.Tests.Data.Investing
{
    [TestClass]
    public class CryptoBasketDataTests : SealedClassTests<NamedEntityData>
    {
        [TestMethod] public void CustomerIDTest() => isProperty<string>(); 
    }
}
