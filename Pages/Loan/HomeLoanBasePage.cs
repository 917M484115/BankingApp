//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using BankingApp.Data.Loan;
//using BankingApp.Domain.Loans;
//using BankingApp.Facade.Loan;
//using BankingApp.Pages.Common;
//using Microsoft.AspNetCore.Html;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.Mvc.Rendering;

//namespace BankingApp.Pages.Loan
//{
//    public abstract class HomeLoansBasePage<TPage> :
//        ViewPage<TPage, IHomeLoanRepository, HomeLoan, HomeLoanView, HomeLoanData>
//        where TPage : PageModel
//    {
//        protected HomeLoansBasePage(IHomeLoanRepository r) : base(r, "Home Loans")
//        {
//        }

//        protected internal override Uri pageUrl() => new Uri("/Loan/HomeLoan", UriKind.Relative);
//        protected internal override HomeLoan toObject(HomeLoanView v) => new HomeLoanViewFactory().Create(v);
//        protected internal override HomeLoanView toView(HomeLoan o) => new HomeLoanViewFactory().Create(o);

//        protected override void createTableColumns()
//        {
//            createColumn(x => Item.Id);
//            createColumn(x => Item.HomeAge);
//            createColumn(x => Item.HomeValue);
//            createColumn(x => Item.LoanPeriod);
//            createColumn(x => Item.Interest);
//            createColumn(x => Item.LoanManagerId);
//        }

//        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
//        {
//            8 or 9 => getName<DateTime?>(h, i),
//            _ => base.GetName(h, i)
//        };

//        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
//        {
//            8 or 9 => getValue<DateTime?>(h, i),
//            _ => base.GetValue(h, i)
//        };
//    }
//}
