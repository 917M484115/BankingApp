using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingApp.Domain.Loans;

namespace BankingApp.Pages.Loan
{
    public sealed class LoanAccountManagerPage : LoanAccountBasePage<LoanAccountManagerPage>
    {
        public LoanAccountManagerPage(ILoanAccountRepository r) : base(r) { }
        protected internal override Uri pageUrl() => new Uri("/LoanManager/LoanAccount", UriKind.Relative);
    }
}
