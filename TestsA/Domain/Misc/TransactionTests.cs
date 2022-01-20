using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Aids.Random;
using BankingApp.Data.Loan;
using BankingApp.Data.Misc;
using BankingApp.Domain.Common;
using BankingApp.Domain.Loans;
using BankingApp.Domain.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.Tests.Domain.Misc
{
    [TestClass]
    public class TransactionTests : SealedClassTests<MoneyAmountEntity<TransactionData>>
    {

        private TransactionData data;
        private Transaction transaction;

        protected override object createObject() => new Transaction(data);

        [TestInitialize]
        public override void TestInitialize()
        {
            data = GetRandom.Object<TransactionData>();
            base.TestInitialize();
            transaction = obj as Transaction;
        }

        [TestMethod] public void RecipientAddressTest() => isProperty(data.RecipientAddress);

        [TestMethod] public void SenderAddressTest() => isProperty(data.SenderAddress);

        [TestMethod] public void NoteTest() => isProperty(data.Note);
        [TestMethod] public void TransactionNrTest() => isProperty(data.TransactionNr);
        [TestMethod] public void AmountSentTest() => isProperty(data.MoneyAmount);
    }
}
