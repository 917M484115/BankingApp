using BankingApp.Tests.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Pages {
    [TestClass]
    public class IsPagesTested : AssemblyBaseTests {
        protected override string assembly => "BankingApp.Pages";
        [TestMethod]
        public void IsCommonTested()
            => isAllTested(assembly, nameSpace("Common"));
        [TestMethod]
        public void IsAidsTested()
            => isAllTested(assembly, nameSpace("Common.Aids"));
        [TestMethod]
        public void IsConstsTested()
            => isAllTested(assembly, nameSpace("Common.Consts"));
        [TestMethod]
        public void IsExtensionTested()
            => isAllTested(assembly, nameSpace("Common.Extensions"));
        [TestMethod]
        public void IsInvestingTested()
            => isAllTested(assembly, nameSpace("Investing"));
    }
}
