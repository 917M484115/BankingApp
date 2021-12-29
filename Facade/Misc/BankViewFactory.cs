using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Misc
{
	public sealed class BankViewFactory : AbstractViewFactory<BankData, Bank, BankView>
	{
		protected internal override Bank toObject(BankData d) => new Bank(d);
	}
}
