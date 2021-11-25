using System;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Loan
{
    public sealed class LoanAccountClientPage : LoanAccountBasePage<LoanAccountClientPage>
    {
        public LoanAccountClientPage(ILoanAccountRepository r) : base(r) { }

    }
}
