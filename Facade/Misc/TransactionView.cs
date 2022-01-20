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
        [DisplayName("Recipient address")] public string RecipientAddress { get; set; }
		[DisplayName("Recipient")] public string RecipientName { get; set; }
        [DisplayName("Sender address")] public string SenderAddress { get; set; }
		[DisplayName("Sender")] public string SenderName { get; set; }
		public string Note { get; set; }
		[DisplayName("Transaction number")] public int TransactionNr { get; set; }
	}
}
