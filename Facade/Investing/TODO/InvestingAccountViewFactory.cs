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
	public sealed class InvestingAccountViewFactory : AbstractViewFactory<InvestingAccountData, InvestingAccount, InvestingAccountView>
	{
		protected internal override InvestingAccount toObject(InvestingAccountData d) => new InvestingAccount(d);
	}
}
