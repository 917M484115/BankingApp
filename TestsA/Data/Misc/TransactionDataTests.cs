using BankingApp.Data;
using BankingApp.Data.Common;
using BankingApp.Data.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Data.Misc
{
    [TestClass]
    public class TransactionDataTests :SealedClassTests<MoneyAmountData>
    {
        [TestMethod] public void RecipientAddressTest() => isProperty<string>();
        [TestMethod] public void SenderAddressTest() => isProperty<string>();
        [TestMethod] public void NoteTest() => isProperty<string>();
        [TestMethod] public void TransactionNrTest() => isProperty<int>(false);
    }
}
