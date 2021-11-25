using System;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Loan
{
    public abstract class HomeLoanBasePage<TPage> :
        ViewPage<TPage, IHomeLoanRepository, HomeLoan, HomeLoanView, HomeLoanData>
        where TPage : PageModel
    {
        protected HomeLoanBasePage(IHomeLoanRepository r) : base(r, "Home Loans")
        {
        }

        protected internal override Uri pageUrl() => new Uri("/Loan/HomeLoan", UriKind.Relative);
        protected internal override HomeLoan toObject(HomeLoanView v) => new HomeLoanViewFactory().Create(v);
        protected internal override HomeLoanView toView(HomeLoan o) => new HomeLoanViewFactory().Create(o);

        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.HomeAge);
            createColumn(x => Item.HomeValue);
            createColumn(x => Item.LoanPeriod);
            createColumn(x => Item.Interest);
            createColumn(x => Item.MonthlyReturn);
            createColumn(x => Item.LoanManagerId);
            

        }

        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            1 or 3 => getName<int>(h, i),
            2 or 4 or 5=> getName<double>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            1 or 3=> getValue<int>(h, i),
            2 or 4 or 5=> getValue<double>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
