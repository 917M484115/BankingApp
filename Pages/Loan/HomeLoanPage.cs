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
    public sealed class HomeLoanPage : ViewPage<HomeLoanPage, IHomeLoanRepository, HomeLoan, HomeLoanView, HomeLoanData>
    {
        public HomeLoanPage(IHomeLoanRepository r) : base(r, "Home Loans") { }
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
            createColumn(x => Item.LoanManagerId);
        }

        public override string GetName(IHtmlHelper<HomeLoanPage> h, int i) => i switch
        {
            1 => getName<int>(h, i),
            2 => getName<double>(h, i),
            3 => getName<int>(h, i),
            4 => getName<double>(h, i),
            _ => base.GetName(h, i)
        };

    }
}
