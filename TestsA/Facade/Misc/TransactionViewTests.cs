using BankingApp.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Misc
{
    [TestClass]
    public class TransactionViewTests : SealedClassTests<MoneyAmountView>
    {
        [TestMethod] public void RecipientAddressTest() => isDisplayProperty<string>("Recipient address");
        [TestMethod] public void RecipientNameTest() => isDisplayProperty<string>("Recipient");
        [TestMethod] public void SenderAddressTest() => isDisplayProperty<string>("Sender address");
        [TestMethod] public void SenderNameTest() => isDisplayProperty<string>("Sender");
        [TestMethod] public void NoteTest() => isDisplayProperty<string>("Note");
        [TestMethod] public void TransactionNrTest() => isDisplayProperty<int>("Transaction number",false);
    }
}
