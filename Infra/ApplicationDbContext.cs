using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BankingApp.Data;
using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using BankingApp.Data.Loan;
using BankingApp.Data.ATM;
namespace BankingApp.Infra
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ATMData> ATM { get; set; }
        public DbSet<ATMManagerData> ATMManager { get; set; }
        public DbSet<AccountData> Account { get; set; }
        public DbSet<InvestingAccountData> InvestingAccount { get; set; }
        public DbSet<InvestmentData> Investment { get; set; }
        public DbSet<LoanAccountData> LoanAccount { get; set; }
        public DbSet<CarLoanData> CarLoan { get; set; }
        public DbSet<HomeLoanData> HomeLoan { get; set; }
        public DbSet<PersonalLoanData> PersonalLoan { get; set; }
        public DbSet<LoanManagerData> LoanManager { get; set; }
        public DbSet<BankData> Bank { get; set; }
        public DbSet<CustomerData> Customer { get; set; }
        public DbSet<NotificationData> Notification { get; set; }
        public DbSet<TransactionData> Transaction { get; set; }
        public DbSet<CalculatorData> Calculator { get; set; }

        //TODO vaadata, kuidas krüptod/stockid listina siia saada. Võib panna käsitsi nt 5 populaarseimat ja listist saab investeerides valida nende vahel.
        //public DbSet<CryptoData> Crypto { get; set; }
        //public DbSet<StockData> Stock { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Calculator>().HasKey(m => m.YieldType);
            modelBuilder.Entity<CalculatorData>().ToTable("Calculator");
            modelBuilder.Entity<ATMData>().ToTable("ATM");
            modelBuilder.Entity<ATMManagerData>().ToTable("ATMManager");
            modelBuilder.Entity<AccountData>().ToTable("Account");
            modelBuilder.Entity<InvestingAccountData>().ToTable("InvestingAccount");
            modelBuilder.Entity<InvestmentData>().ToTable("Investment");
            modelBuilder.Entity<LoanAccountData>().ToTable("LoanAccount");
            modelBuilder.Entity<CarLoanData>().ToTable("CarLoan");
            modelBuilder.Entity<HomeLoanData>().ToTable("HomeLoan");
            modelBuilder.Entity<PersonalLoanData>().ToTable("PersonalLoan");
            modelBuilder.Entity<LoanManagerData>().ToTable("LoanManager");
            modelBuilder.Entity<BankData>().ToTable("Bank");
            modelBuilder.Entity<CustomerData>().ToTable("Customer");
            modelBuilder.Entity<NotificationData>().ToTable("Notification");
            modelBuilder.Entity<TransactionData>().ToTable("Transaction");
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
