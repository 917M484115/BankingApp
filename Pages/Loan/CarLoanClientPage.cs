using BankingApp.Domain.Loans;

namespace BankingApp.Pages.Loan
{
    public sealed class CarLoanClientPage : CarLoanBasePage<CarLoanClientPage>
    {
        public CarLoanClientPage(ICarLoanRepository r) : base(r) { }
    }
}
