using BankingApp.Domain.Loans;


namespace BankingApp.Pages.Loan
{
    public sealed class CarLoanPage : CarLoanBasePage<CarLoanPage>
    {
        public CarLoanPage(ICarLoanRepository r) : base(r) { }
    }
}
