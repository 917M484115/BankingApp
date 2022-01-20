using BankingApp.Data.Common;

namespace BankingApp.Data.Misc
{
    public sealed class NotificationData : UniqueEntityData
    {
        public string TransactionId { get; set; }
        public string ATMProcessId { get; set; }
        public string LoanId { get; set; }
        public string InvestmentId { get; set; }
        public string CurrencySwapId { get; set; }
    }
}
