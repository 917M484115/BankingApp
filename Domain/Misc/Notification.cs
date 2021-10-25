using BankingApp.Data;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Misc
{
	public sealed class Notification : UniqueEntity<NotificationData>
	{
		public Notification(NotificationData d) : base(d) { }
		public string TransactionId => Data?.TransactionId ?? Unspecified;
		public string ATMProcessId => Data?.ATMProcessId ?? Unspecified;
		public string LoanId => Data?.LoanId ?? Unspecified;
		public string InvestmentId => Data?.InvestmentId ?? Unspecified;
		public string CurrencySwapId => Data?.CurrencySwapId ?? Unspecified;

	}
}
