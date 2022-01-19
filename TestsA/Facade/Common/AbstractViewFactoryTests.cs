using BankingApp.Aids.Random;
using BankingApp.Data;
using BankingApp.Domain;
using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;

namespace BankingApp.Tests.Facade.Common {
    [TestClass] public class AbstractViewFactoryTests : AbstractClassTests<object> {
        private class testClass : AbstractViewFactory<BlockChainData, BlockChain, BlockChainView> {
            protected override BlockChain toObject(BlockChainData d) => new (d);
        }
        [TestMethod] public void CreateTest() {}
        [TestMethod] public void CreateObjectTest() {
            var v = random<BlockChainView>();
            var o = (obj as testClass).Create(v);
            areEqualProperties(v, o.Data);
        }
        [TestMethod] public void CreateViewTest() {
            var d = random<BlockChainData>();
            var v = (obj as testClass).Create(new BlockChain(d));
            areEqualProperties(d, v);
        }
        protected override object createObject() => new testClass();
    }
}
