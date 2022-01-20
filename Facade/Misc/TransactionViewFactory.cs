using BankingApp.Domain.Misc;
using BankingApp.Facade.Common;
using BankingApp.Data.Misc;
namespace BankingApp.Facade.Misc
{
	public sealed class TransactionViewFactory : AbstractViewFactory<TransactionData, Transaction, TransactionView>
	{
		protected internal override Transaction toObject(TransactionData d) => new Transaction(d);

		public override TransactionView Create(Transaction o)
		{
			var v = base.Create(o);
			v.RecipientAddress = o.RecipientAddress;
			v.RecipientName = o.RecipientName;
			v.SenderAddress = o.SenderAddress;
			v.SenderName = o.SenderName;
			v.Note = o.Note;
			v.TransactionNr = o.TransactionNr;
            v.MoneyAmount = o.AmountSent;
			return v;
		}
	}
}
