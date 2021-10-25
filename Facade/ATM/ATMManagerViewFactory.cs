using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.ATM;
using BankingApp.Domain.ATMs;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.ATM
{
	public sealed class ATMManagerViewFactory : AbstractViewFactory<ATMManagerData, ATMManager, ATMManagerView>
	{
		protected internal override ATMManager toObject(ATMManagerData d) => new ATMManager(d);
	}
}
