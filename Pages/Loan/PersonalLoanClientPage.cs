using BankingApp.Domain.Loans;

namespace BankingApp.Pages.Loan
{
    public sealed class PersonalLoanClientPage : PersonalLoanBasePage<PersonalLoanClientPage>
    {
        public PersonalLoanClientPage(IPersonalLoanRepository r) : base(r) { }
    }
}
