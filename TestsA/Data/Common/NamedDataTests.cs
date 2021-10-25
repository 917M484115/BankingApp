using BankingApp.Aids;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Common
{
    [TestClass]
    public class NamedEntityDataTests : AbstractClassTests<NamedEntityData, UniqueEntityData>
    {
        private class testClass : NamedEntityData { }
        protected override NamedEntityData getObject() => GetRandom.ObjectOf<testClass>();
        [TestMethod] public void NameTest() => isReadWriteProperty<string>();
    }
}
