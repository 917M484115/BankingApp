using System;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Data.Investing;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Investing
{
    public abstract class InvestingAccountBasePage<TPage> :
       ViewPage<TPage, IInvestingAccountRepository, InvestingAccount, InvestingAccountView, InvestingAccountData>
       where TPage : PageModel
    {
        public InvestingAccountBasePage(IInvestingAccountRepository r) : base(r, "Investing accounts") { }
        protected internal override Uri pageUrl() => new Uri("/Investing/InvestingAccount", UriKind.Relative);
        protected internal override InvestingAccount toObject(InvestingAccountView v) => new InvestingAccountViewFactory().Create(v);
        protected internal override InvestingAccountView toView(InvestingAccount o) => new InvestingAccountViewFactory().Create(o);
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
            5 => getName<int>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            5 => getValue<int>(h, i),
            _ => base.GetValue(h, i)
        };

    }
}
