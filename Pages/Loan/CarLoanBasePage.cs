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
    public abstract class CarLoanBasePage<TPage> :
        ViewPage<TPage, ICarLoanRepository, CarLoan, CarLoanView, CarLoanData>
        where TPage : PageModel
    {
        protected CarLoanBasePage(ICarLoanRepository r) : base(r, "Car Loans")
        {
        }

        protected internal override Uri pageUrl() => new Uri("/Loan/CarLoan", UriKind.Relative);
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
            2 => getName<double>(h, i),
            3 => getName<int>(h, i),
            _ => base.GetName(h, i)
        };


    }
}
