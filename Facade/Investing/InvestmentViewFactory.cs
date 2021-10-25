using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
	public sealed class InvestmentViewFactory : AbstractViewFactory<InvestmentData, Investment, InvestmentView>
	{
		protected internal override Investment toObject(InvestmentData d) => new Investment(d);

		public override InvestmentView Create(Investment o)
		{
			var v = base.Create(o);
			v.CurrentAmount = o.CurrentAmount;
			v.Description = o.Description;
			return v;
		}
	}
}
