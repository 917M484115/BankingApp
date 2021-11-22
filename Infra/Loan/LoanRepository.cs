using BankingApp.Data.Loan;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Common;

namespace BankingApp.Infra.Loan
{
    public abstract class LoanRepository :
        MoneyAmountRepository<Loan<LoanData>, LoanData>
    {
        public LoanRepository(ApplicationDbContext c) : base(c, c.Loan) { }
        protected internal override Loan<LoanData> toDomainObject(LoanData d)
            => new Loan<LoanData>(d);
    }
}