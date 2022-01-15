using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Pages.Investing
{
    public sealed class InvestingAccountClientPage : InvestingAccountBasePage<InvestingAccountClientPage>
    {
        public InvestingAccountClientPage(IInvestingAccountRepository r) : base(r) { }

    }
}
