using BankingApp.Domain.Loans;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingApp.Pages.Loan
{
    public sealed class LoanAccountClientPage : LoanAccountBasePage<LoanAccountClientPage>
    {
        public LoanAccountClientPage(ILoanAccountRepository r) : base(r) { }
        
    }
}
