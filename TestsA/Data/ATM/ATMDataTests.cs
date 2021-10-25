using BankingApp.Data.ATM;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.ATM
{
    [TestClass]
    public class ATMDataTests : SealedClassTests<ATMData, MoneyAmountData>
    {
        [TestMethod] public void LocationTest() => isReadWriteProperty<string>();
        [TestMethod] public void ManagerTest() => isReadWriteProperty<string>();
    }

}
