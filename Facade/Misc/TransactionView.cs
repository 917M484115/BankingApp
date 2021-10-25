using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Misc
{
	public sealed class TransactionView: MoneyAmountView
	{
		public string RecipientId { get; set; }
		[DisplayName("Recipient")] public string RecipientName { get; set; }
		public string SenderId { get; set; }
		[DisplayName("Sender")] public string SenderName { get; set; }
		public string Note { get; set; }
		[DisplayName("Transaction number")] public int TransactionNr { get; set; }
	}
}
