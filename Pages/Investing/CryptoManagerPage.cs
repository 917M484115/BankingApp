using System;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoManagerPage : CryptoBasePage<CryptoManagerPage>
    {
        public CryptoManagerPage(ICryptoRepository r) : base(r) { }

        protected internal override Uri pageUrl() => new Uri("/InvestingManager/Crypto", UriKind.Relative);

    }
}