using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data.ATM;
using BankingApp.Data.Loan;
using BankingApp.Domain.ATMs;
using BankingApp.Domain.Loans;
using BankingApp.Facade.ATM;
using BankingApp.Facade.Loan;
using BankingApp.Pages.Common;
using BankingApp.Pages.Loan;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Bank
{
    public sealed class ATMManagerPage : ViewPage<ATMManagerPage, IATMManagerRepository, ATMManager, ATMManagerView, ATMManagerData>
    {
        public ATMManagerPage(IATMManagerRepository r) : base(r, "ATM Managers") { }
        protected internal override Uri pageUrl() => new Uri("/Bank/ATMManager", UriKind.Relative);
        protected internal override ATMManager toObject(ATMManagerView v) => new ATMManagerViewFactory().Create(v);
        protected internal override ATMManagerView toView(ATMManager o) => new ATMManagerViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.Age);
            createColumn(x => Item.Country);
        }

        public override string GetName(IHtmlHelper<ATMManagerPage> h, int i) => i switch
        {
            1 => getName<int>(h, i),
            2 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

    }
}
