using BankingApp.Aids;
using BankingApp.Data;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data
{
    [TestClass]
    public class CustomerDataTests : SealedClassTests<CustomerData, PersonData>
    {
        [TestMethod] public void AccountIdTest() => isReadWriteProperty<string>();
    }
}
