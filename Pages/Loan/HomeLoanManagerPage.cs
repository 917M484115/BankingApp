using System;
using BankingApp.Domain.Loans;


namespace BankingApp.Pages.Loan
{
    public sealed class HomeLoanManagerPage : HomeLoanBasePage<HomeLoanManagerPage>
    {
        public HomeLoanManagerPage(IHomeLoanRepository r) : base(r) { }

        protected internal override Uri pageUrl() => new Uri("/LoanManager/HomeLoan", UriKind.Relative);
    }

}
