using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.ATM
{
    [TestClass]
    public class ATMDataTests : SealedClassTests<MoneyAmountData>
    {
        [TestMethod] public void LocationTest() => isProperty<string>();
        [TestMethod] public void ManagerTest() => isProperty<string>();
    }

}
