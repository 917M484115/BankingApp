using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Misc
{
	public sealed class NotificationView: UniqueEntityView
	{
		public string TransactionId { get; set; }
		public string ATMProcessId { get; set; }
		public string LoanId { get; set; }
		public string InvestmentId { get; set; }
		public string CurrencySwapId { get; set; }
	}
}
