using BankingApp.Domain.Investing.Repositories;
namespace BankingApp.Pages.Investing
{
    public sealed class InvestingAccountManagerPage : InvestingAccountBasePage<InvestingAccountManagerPage>
    {
        public InvestingAccountManagerPage(IInvestingAccountRepository r) : base(r) { }

    }
}
