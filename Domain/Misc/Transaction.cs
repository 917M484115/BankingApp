using BankingApp.Data.Misc;
using BankingApp.Domain.Common;
using BankingApp.Domain.Loans;

namespace BankingApp.Domain.Misc
{
    public sealed class Transaction : MoneyAmountEntity<TransactionData>
    {
        public Transaction(TransactionData d) : base(d) { }
        public string RecipientAddress => Data?.RecipientAddress ?? Unspecified;
        public string SenderAddress => Data?.SenderAddress ?? Unspecified;
        public string Note => Data?.Note ?? Unspecified;
        public int TransactionNr => Data?.TransactionNr ?? 0;

        public double AmountSent => Data?.MoneyAmount ?? 0;


        public LoanAccount Sender => new GetFrom<ILoanAccountRepository, LoanAccount>().ByAddress(SenderAddress);
        public string SenderName => Sender?.AccountOwnerName;

        public double SenderBalance => Sender.MoneyAmount - AmountSent;


        public LoanAccount Recipient => new GetFrom<ILoanAccountRepository, LoanAccount>().ByAddress(RecipientAddress);
        public string RecipientName => Recipient?.AccountOwnerName;

        public double RecipientBalance => Recipient.MoneyAmount + AmountSent;

        //TODO transaction








    }
}
