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
	public sealed class NotificationViewFactory : AbstractViewFactory<NotificationData, Notification, NotificationView>
	{
		protected internal override Notification toObject(NotificationData d) => new Notification(d);

		public override NotificationView Create(Notification o)
		{
			var v = base.Create(o);
			v.TransactionId = o.TransactionId;
			v.ATMProcessId = o.ATMProcessId;
			v.LoanId = o.LoanId;
			v.InvestmentId = o.InvestmentId;
			v.CurrencySwapId = o.CurrencySwapId;
			return v;
		}
	}
}
