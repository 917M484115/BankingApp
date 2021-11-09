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
    public abstract class CarLoansBasePage<TPage> :
        ViewPage<TPage, ICarLoanRepository, CarLoan, CarLoanView, CarLoanData>
        where TPage : PageModel
    {
        protected CarLoansBasePage(ICarLoanRepository r) : base(r, "Car Loans")
        {
        }

        protected internal override Uri pageUrl() => new Uri("/Loan/CarLoans", UriKind.Relative);
        protected internal override CarLoan toObject(CarLoanView v) => new CarLoanViewFactory().Create(v);
        protected internal override CarLoanView toView(CarLoan o) => new CarLoanViewFactory().Create(o);

        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.CarType);
            createColumn(x => Item.CarValue);
            createColumn(x => Item.CarAge);
        }

        public override string GetName(IHtmlHelper<TPage> h, int i) => i switch
        {
            8 or 9 => getName<DateTime?>(h, i),
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i) => i switch
        {
            8 or 9 => getValue<DateTime?>(h, i),
            _ => base.GetValue(h, i)
        };
    }
}
