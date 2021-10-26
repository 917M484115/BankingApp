using BankingApp.Data;
using BankingApp.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data
{
    [TestClass]
    public class TransactionDataTests :SealedClassTests<MoneyAmountData>
    {
        [TestMethod] public void RecipientIdTest() => isProperty<string>();
        [TestMethod] public void RecipientNameTest() => isProperty<string>();
        [TestMethod] public void SenderIdTest() => isProperty<string>();
        [TestMethod] public void SenderNameTest() => isProperty<string>();
        [TestMethod] public void NoteTest() => isProperty<string>();
        [TestMethod] public void TransactionNrTest() => isProperty<int>();
    }
}
