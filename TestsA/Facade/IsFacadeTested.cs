using BankingApp.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade
{
    [TestClass]
    public class IsFacadeTested : AssemblyBaseTests
    {
        protected override string assembly => "BankingApp.Facade";
        [TestMethod]
        public void IsCommonTested()
            => isAllTested(assembly, nameSpace("Common"));
        [TestMethod]
        public void IsInvestingTested()
            => isAllTested(assembly, nameSpace("Investing"));
    }
}
