using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
	public sealed class CryptoViewFactory : AbstractViewFactory<CryptoData, Crypto, CryptoView>
	{
		protected internal override Crypto toObject(CryptoData d) => new Crypto(d);
	}
}
