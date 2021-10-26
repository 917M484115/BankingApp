using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using BankingApp.Infra;
using BankingApp.Pages.Common;
using System;

namespace BankingApp.Pages.Loan
{
    public sealed class CarLoanPage : ViewPage<CarLoanPage, ICarLoanRepository, CarLoan, CarLoanView, CarLoanData>
    {
        public CarLoanPage(ICarLoanRepository r) : base(r, "CarLoans") { }
        protected internal override Uri pageUrl() => new Uri("/Shop/CarLoans", UriKind.Relative);
        protected internal override CarLoan toObject(CarLoanView v) => new CarLoanViewFactory().Create(v);
        protected internal override CarLoanView toView(CarLoan o) => new CarLoanViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.CarType);
            createColumn(x => Item.CarValue);;
            createColumn(x => Item.CarAge);
        }
    }
}
