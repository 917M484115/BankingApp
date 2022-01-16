using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BankingApp.Tests.Data.Common
{
    [TestClass]
    public class VirtualEntityDataTests : AbstractClassTests<NamedEntityData>
    {
        private class testClass : VirtualAssetData { }
        protected override object createObject() => new testClass();
        [TestMethod] public void TickerTest() => isProperty<string>();
        [TestMethod] public void PriceTest() => isProperty<decimal>(false);
    }
}
