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
	public sealed class BankViewFactory : AbstractViewFactory<BankData, Bank, BankView>
	{
		protected internal override Bank toObject(BankData d) => new Bank(d);
	}
}
