using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Facade.Loan;
using BankingApp.Infra;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;
using BankingApp.Aids;
using Microsoft.AspNetCore.Mvc;


namespace BankingApp.Pages.Loan
{
    public sealed class CarLoanPage : CarLoanBasePage<CarLoanPage>
    {
        public CarLoanPage(ICarLoanRepository r) : base(r) { }
    }

    //TODO Baaslehest saada pärimine korda. Seda on vaja, et luua ka LoanManagerile puhtamalt lehed.
}
