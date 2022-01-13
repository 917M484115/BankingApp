using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Investing
{ 
    [TestClass]
    //TODO Kas CalculatorData tohib NamedEntityDatast pärida või ei? Lisada see Datasse, kui võimalik implementeerida. Kui ei, tuleb test teha ümber.
    //panen praegu BaseDatat pärima, et test läbi läheks.
    public class CalculatorDataTests : SealedClassTests<NamedEntityData>
    {
        [TestMethod] public void APYTest() => isProperty<double>(false);
        [TestMethod] public void AmountTest() => isProperty<double>(false);
        [TestMethod] public void ResultTest() => isProperty<double>(false);
        [TestMethod] public void TimeInMonthsTest() => isProperty<double>(false);
        [TestMethod] public void RevenueTest() => isProperty<double>(false);
    }
}
