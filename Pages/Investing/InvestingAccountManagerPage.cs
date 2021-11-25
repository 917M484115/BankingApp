using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Domain.Investing;

namespace BankingApp.Pages.Investing
{
    public sealed class InvestingAccountManagerPage : InvestingAccountBasePage<InvestingAccountManagerPage>
    {
        public InvestingAccountManagerPage(IInvestingAccountRepository r) : base(r) { }

    }
}
