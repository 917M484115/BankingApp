using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Investing
{ 
    [TestClass]
    public class CalculatorDataTests : SealedClassTests<NamedEntityData>
    {
        [TestMethod] public void APYTest() => isProperty<double>(false);
       
    }
}
