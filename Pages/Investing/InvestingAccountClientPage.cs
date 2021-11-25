using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Domain.Investing;


namespace BankingApp.Pages.Investing
{
    public sealed class InvestingAccountClientPage : InvestingAccountBasePage<InvestingAccountClientPage>
    {
        public InvestingAccountClientPage(IInvestingAccountRepository r) : base(r) { }

    }
}
