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
    public abstract class PersonalLoanBasePage<TPage> :
        ViewPage<TPage, IPersonalLoanRepository, PersonalLoan, PersonalLoanView, PersonalLoanData>
        where TPage : PageModel
    {
        public PersonalLoanBasePage(IPersonalLoanRepository r) : base(r, "Personal Loans") { }
        protected internal override Uri pageUrl() => new Uri("/Loan/PersonalLoan", UriKind.Relative);
        protected internal override PersonalLoan toObject(PersonalLoanView v) => new PersonalLoanViewFactory().Create(v);
        protected internal override PersonalLoanView toView(PersonalLoan o) => new PersonalLoanViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Reason);
            createColumn(x => Item.LoanPeriod);
            createColumn(x => Item.Interest);
            createColumn(x => Item.LoanManagerId);
        }

        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            2 => getName<int>(h, i),
            3 => getName<double>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            2 => getValue<int>(h, i),
            3 => getValue<double>(h, i),
            _ => base.GetValue(h, i)
        };

    }
}
