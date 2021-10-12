using BankingApp.Data;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.ATM
{
    [TestClass]
    public class ATMDataTests : SealedClassTests<ATMData, MoneyAmountData>
    {
        [TestMethod] public void LocationTest() => isReadWriteProperty<string>();
        [TestMethod] public void ManagerTest() => isReadWriteProperty<string>();
    }

}
