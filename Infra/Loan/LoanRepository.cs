using BankingApp.Data.Common;
using BankingApp.Data.Loan;
using BankingApp.Domain.Common;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;
using Microsoft.EntityFrameworkCore;

namespace BankingApp.Infra.Loan
{
    public abstract class LoanRepository<TDomain, TData> : MoneyAmountRepository<TDomain, TData>
        where TDomain : IEntity<TData>
        where TData : MoneyAmountData, new()

    {
        protected LoanRepository(DbContext c, DbSet<TData> s) : base(c, s) { }
    }
}