using BankingApp.Data.Common;

namespace BankingApp.Data.Misc
{
    public sealed class TransactionData : MoneyAmountData
    {
        public string RecipientAddress { get; set; }
        public string SenderAddress { get; set; }
        public string Note { get; set; }
        public int TransactionNr  { get; set; }

    }
}
