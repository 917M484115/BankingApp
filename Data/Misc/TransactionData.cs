using BankingApp.Data.Common;

namespace BankingApp.Data
{
    public sealed class TransactionData : MoneyAmountData
    {
        public string RecipientId { get; set; }
        public string RecipientName { get; set; }

        public string SenderId { get; set; }
        public string SenderName { get; set; }
        public string Note { get; set; }
        public int TransactionNr  { get; set; }

    }
}
