using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Loan
{
    public sealed class PersonalLoanPage : ViewPage<PersonalLoanPage, IPersonalLoanRepository, PersonalLoan, PersonalLoanView, PersonalLoanData>
    {
        public PersonalLoanPage(IPersonalLoanRepository r) : base(r, "Personal Loans") { }
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

        public override string GetName(IHtmlHelper<PersonalLoanPage> h, int i) => i switch
        {
            2 => getName<int>(h, i),
            3 => getName<double>(h, i),
            _ => base.GetName(h, i)
        };

    }
}
