using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Investing
{ 
    [TestClass]
    //TODO Kas CalculatorData tohib NamedEntityDatast pärida või ei? Lisada see Datasse, kui võimalik implementeerida. Kui ei, tuleb test teha ümber.
    //panen praegu BaseDatat pärima, et test läbi läheks.
    public class CalculatorDataTests : SealedClassTests<NamedEntityData>
    {
        [TestMethod] public void YieldIdTest() => isProperty<int>();
        [TestMethod] public void YieldNameTest() => isProperty<string>();
        [TestMethod] public void APYTest() => isProperty<double>();
    }
}
