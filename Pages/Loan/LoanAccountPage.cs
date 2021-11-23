using System;
using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Loan
{
    public sealed class LoanAccountPage : ViewPage<LoanAccountPage, ILoanAccountRepository, LoanAccount, LoanAccountView
        , LoanAccountData>
    {
        public LoanAccountPage(ILoanAccountRepository r) : base(r, "Loan Accounts")
        {
        }

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

        public override string GetName(IHtmlHelper<LoanAccountPage> h, int i) => i switch
        {
            5 => getName<double>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<LoanAccountPage> h, int i) => i switch
        {
            5 => getValue<double>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
