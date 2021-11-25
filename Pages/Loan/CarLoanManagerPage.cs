using System;
using BankingApp.Domain.Loans;

namespace BankingApp.Pages.Loan
{
    public sealed class CarLoanManagerPage : CarLoanBasePage<CarLoanManagerPage>
    {
        public CarLoanManagerPage(ICarLoanRepository r) : base(r) { }

        protected internal override Uri pageUrl() => new Uri("/LoanManager/CarLoan", UriKind.Relative);
        
    }
}
