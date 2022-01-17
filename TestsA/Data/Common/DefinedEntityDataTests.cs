using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Common
{
    [TestClass] public class DefinedEntityDataTests : AbstractClassTests<NamedEntityData> {
        private class testClass : DefinedEntityData { }
        protected override object createObject() => new testClass();
        [TestMethod] public void DefinitionTest() => isProperty<string>();
    }

}
