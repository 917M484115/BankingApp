using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data;
using BankingApp.Domain.Common;

namespace BankingApp.Domain
{
	public sealed class Notification : BaseEntity<NotificationData>
	{
		public Notification(NotificationData d) : base(d) { }
		public string TransactionId => Data?.TransactionId ?? "Unspecified";
		public string ATMProcessId => Data?.ATMProcessId ?? "Unspecified";
		public string LoanId => Data?.LoanId ?? "Unspecified";
		public string InvestmentId => Data?.InvestmentId ?? "Unspecified";
		public string CurrencySwapId => Data?.CurrencySwapId ?? "Unspecified";

	}
}
