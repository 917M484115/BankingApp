using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data
{
    [TestClass]
    public class NotificationDataTests : SealedClassTests<UniqueEntityData>
    {
        [TestMethod] public void TransactionIdTest() => isProperty<string>();
        [TestMethod] public void ATMProcessIdTest() => isProperty<string>();
        [TestMethod] public void LoanIdTest() => isProperty<string>();
        [TestMethod] public void InvestmentIdTest() => isProperty<string>();

        [TestMethod] public void CurrencySwapIdTest() => isProperty<string>();
    }
}
