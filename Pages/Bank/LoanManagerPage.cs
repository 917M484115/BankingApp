using System;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Bank
{
    public sealed class LoanManagerPage : ViewPage<LoanManagerPage, ILoanManagerRepository, LoanManager, LoanManagerView, LoanManagerData>
    {
        public LoanManagerPage(ILoanManagerRepository r) : base(r, "Loan Managers") { }
        protected internal override Uri pageUrl() => new Uri("/Bank/LoanManager", UriKind.Relative);
        protected internal override LoanManager toObject(LoanManagerView v) => new LoanManagerViewFactory().Create(v);
        protected internal override LoanManagerView toView(LoanManager o) => new LoanManagerViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Age);
            createColumn(x => Item.Country);
        }

        public override string GetName(IHtmlHelper<LoanManagerPage> h, int i) => i switch
        {
            1 => getName<int>(h, i),
            2 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

    }
}

