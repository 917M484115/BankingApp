using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Misc
{
	public sealed class TransactionViewFactory : AbstractViewFactory<TransactionData, Transaction, TransactionView>
	{
		protected internal override Transaction toObject(TransactionData d) => new Transaction(d);

		public override TransactionView Create(Transaction o)
		{
			var v = base.Create(o);
			v.RecipientId = o.RecipientId;
			v.RecipientName = o.RecipientName;
			v.SenderId = o.SenderId;
			v.SenderName = o.SenderName;
			v.Note = o.Note;
			v.TransactionNr = o.TransactionNr;
			return v;
		}
	}
}
