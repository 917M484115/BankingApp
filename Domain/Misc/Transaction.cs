using BankingApp.Data.Misc;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Misc
{
    public sealed class Transaction : MoneyAmountEntity<TransactionData>
    {
        public Transaction(TransactionData d) : base(d) { }
        public string RecipientId => Data?.RecipientId ?? Unspecified;
        public string RecipientName => Data?.RecipientName ?? Unspecified;
        public string SenderId => Data?.SenderId ?? Unspecified;
        public string SenderName => Data?.SenderName ?? Unspecified;
        public string Note => Data?.Note ?? Unspecified;
        public int TransactionNr => Data?.TransactionNr ?? 0;
    }
}
