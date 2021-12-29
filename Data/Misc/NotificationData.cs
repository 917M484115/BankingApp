using BankingApp.Data.Common;

namespace BankingApp.Data.Misc
{
    public sealed class NotificationData : UniqueEntityData
    {
        public string TransactionId { get; }
        public string ATMProcessId { get; }
        public string LoanId { get; }
        public string InvestmentId { get; }
        public string CurrencySwapId { get; }
    }
}
