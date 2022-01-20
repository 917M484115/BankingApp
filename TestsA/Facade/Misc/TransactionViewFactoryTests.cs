using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Facade.Misc
{
    [TestClass]
    public class TransactionViewFactoryTests : FactoryBaseTests<TransactionViewFactory, TransactionData, Transaction, TransactionView>
    {
        protected override Transaction createObject(TransactionData d) => new(d);

        protected override void doAfterCreateViewTest(Transaction o, TransactionView v)
        {
            areEqual(o.RecipientAddress, v.RecipientAddress);
            areEqual(o.RecipientName, v.RecipientName);
            areEqual(o.SenderAddress, v.SenderAddress);
            areEqual(o.SenderName, v.SenderName);
            areEqual(o.Note, v.Note);
            areEqual(o.TransactionNr, v.TransactionNr);
            areEqual(o.AmountSent, v.MoneyAmount);
        }
    }
}
