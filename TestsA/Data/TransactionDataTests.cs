using BankingApp.Data;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data
{
    [TestClass]
    public class TransactionDataTests :SealedClassTests<TransactionData, MoneyAmountData>
    {
        [TestMethod] public void RecipientIdTest() => isReadWriteProperty<string>();
        [TestMethod] public void RecipientNameTest() => isReadWriteProperty<string>();
        [TestMethod] public void SenderIdTest() => isReadWriteProperty<string>();
        [TestMethod] public void SenderNameTest() => isReadWriteProperty<string>();
        [TestMethod] public void NoteTest() => isReadWriteProperty<string>();
        [TestMethod] public void TransactionNrTest() => isReadWriteProperty<int>();
    }
}
