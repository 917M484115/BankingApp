using BankingApp.Data.Investing;
using BankingApp.Domain.Misc;

namespace BankingApp.Domain.Investing
{
    public sealed class InvestingAccount : AccountEntity<InvestingAccountData>
    {
        public InvestingAccount(InvestingAccountData d) : base(d) { }
    }
}
