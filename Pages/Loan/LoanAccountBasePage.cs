using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Loan
{
    public abstract class LoanAccountBasePage<TPage> :
        ViewPage<TPage, ILoanAccountRepository, LoanAccount, LoanAccountView, LoanAccountData>
        where TPage : PageModel
    {
        public LoanAccountBasePage(ILoanAccountRepository r) : base(r, "Loan accounts") { }
        protected internal override Uri pageUrl() => new Uri("/Loan/LoanAccount", UriKind.Relative);
        protected internal override LoanAccount toObject(LoanAccountView v) => new LoanAccountViewFactory().Create(v);
        protected internal override LoanAccountView toView(LoanAccount o) => new LoanAccountViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.AccountAddress);
            createColumn(x => Item.AccountNickname);
            createColumn(x => Item.CustomerId);
            createColumn(x => Item.AccountLocation);
            createColumn(x => Item.MoneyAmount);

        }

        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            5 => getName<double>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            5 => getValue<double>(h, i),
            _ => base.GetValue(h, i)
        };

    }
}
