using BankingApp.Infra;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Infra
{
    [TestClass]
    public class ConstantsTests: BaseTests
    {
        [TestInitialize]
        public void TestInitialize() {
            type = typeof(Constants);
        }
        [TestMethod]
        public void DefaultPageSizeTest() => areEqual((byte)5, Constants.DefaultPageSize);
    }
}
