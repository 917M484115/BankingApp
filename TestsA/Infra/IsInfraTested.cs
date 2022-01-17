using BankingApp.Tests;
using BankingApp.Tests.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra
{
    [TestClass]
    public class IsInfraTested : AssemblyBaseTests
    {
        protected override string assembly => "BankingApp.Infra";
        [TestMethod]
        public void IsCommonTested()
            => isAllTested(assembly, nameSpace("Common"));
        [TestMethod]
        public void IsInvestingTested()
            => isAllTested(assembly, nameSpace("Investing"));
    }
}
