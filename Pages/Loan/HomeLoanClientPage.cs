using BankingApp.Domain.Loans;


namespace BankingApp.Pages.Loan
{
    public sealed class HomeLoanClientPage : HomeLoanBasePage<HomeLoanClientPage>
    {
        public HomeLoanClientPage(IHomeLoanRepository r) : base(r) { }
    }

}
