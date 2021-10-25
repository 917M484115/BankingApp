using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data
{
    [TestClass]
    public class NotificationDataTests : SealedClassTests<NotificationData, UniqueEntityData>
    {
        [TestMethod] public void TransactionIdTest() => isReadOnlyProperty<string>();
        [TestMethod] public void ATMProcessIdTest() => isReadOnlyProperty<string>();
        [TestMethod] public void LoanIdTest() => isReadOnlyProperty<string>();
        [TestMethod] public void InvestmentIdTest() => isReadOnlyProperty<string>();

        [TestMethod] public void CurrencySwapIdTest() => isReadOnlyProperty<string>();
    }
}
