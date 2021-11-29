using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoClientPage : CryptoBasePage<CryptoClientPage>
    {
        public CryptoClientPage(ICryptoRepository r) : base(r) { }

    }
}
