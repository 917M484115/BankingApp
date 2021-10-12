using BankingApp.Data.Common;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Investing
{ 
    [TestClass]
    //TODO Kas CalculatorData tohib BaseDatast pärida või ei? Lisada see Datasse, kui võimalik implementeerida. Kui ei, tuleb test teha ümber.
    //panen praegu BaseDatat pärima, et test läbi läheks.
    public class CalculatorDataTests : SealedClassTests<CalculatorData,BaseData>
    {
        [TestMethod] public void YieldIdTest() => isReadWriteProperty<int>();
        [TestMethod] public void YieldNameTest() => isReadWriteProperty<string>();
        [TestMethod] public void APYTest() => isReadWriteProperty<double>();
    }
}
