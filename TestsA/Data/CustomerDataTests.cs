using BankingApp.Aids;
using BankingApp.Data;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data
{
    [TestClass]
    public class CustomerDataTests : SealedClassTests<PersonData>
    {
        [TestMethod] public void AccountIdTest() => isProperty<string>();
    }
}
