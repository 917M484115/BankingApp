using System;
using BankingApp.Domain.Loans;

namespace BankingApp.Pages.Loan
{
    public sealed class PersonalLoanManagerPage : PersonalLoanBasePage<PersonalLoanManagerPage>
    {
        public PersonalLoanManagerPage(IPersonalLoanRepository r) : base(r) { }

        protected internal override Uri pageUrl() => new Uri("/LoanManager/PersonalLoan", UriKind.Relative);
    }
}
