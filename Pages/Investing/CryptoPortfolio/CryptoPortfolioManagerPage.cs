using BankingApp.Domain.Investing.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Pages.Investing
{
    public sealed class CryptoPortfolioManagerPage : CryptoPortfolioBasePage<CryptoPortfolioManagerPage>
    {
        public  CryptoPortfolioManagerPage(ICryptoPortfolioRepository r) : base(r)
        {
        }
    }
}
