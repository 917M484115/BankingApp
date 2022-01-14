using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BankingApp.Data.Misc;
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
        public DbSet<LoanData> Loan { get; set; }
        public DbSet<CarLoanData> CarLoan { get; set; }
        public DbSet<HomeLoanData> HomeLoan { get; set; }
        public DbSet<PersonalLoanData> PersonalLoan { get; set; }
        public DbSet<LoanManagerData> LoanManager { get; set; }
        public DbSet<BankData> Bank { get; set; }
        public DbSet<NotificationData> Notification { get; set; }
        public DbSet<TransactionData> Transaction { get; set; }

        public DbSet<CryptoBasketData> CryptoBaskets { get; set; }
        public DbSet<StocksBasketData> StocksBaskets { get; set; }
        public DbSet<StocksBasketItemData> StocksBasketItems { get; set; }
        public DbSet<CryptoBasketItemData> CryptoBasketItems { get; set; }
        public DbSet<OrderData> Orders { get; set; }
        public DbSet<OrderItemData> OrderItems { get; set; }
        public DbSet<CustomerData> Customer { get; set; }
        public DbSet<CalculatorData> Calculator { get; set; }
        public DbSet<StockData> Stock { get;set;}

        public DbSet<CryptoData> Crypto { get;set;}

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            InitializeTables(b);
        }
        //TODO vaadata, kuidas krüptod/stockid listina siia saada. Võib panna käsitsi nt 5 populaarseimat ja listist saab investeerides valida nende vahel.
        //public DbSet<CryptoData> Crypto { get; set; }
        //public DbSet<StockData> Stock { get; set; }
        public static void InitializeTables(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CryptoBasketData>().ToTable(nameof(CryptoBaskets));
            modelBuilder.Entity<StocksBasketData>().ToTable(nameof(StocksBaskets));
            modelBuilder.Entity<CryptoBasketItemData>().ToTable(nameof(CryptoBasketItems));
            modelBuilder.Entity<StocksBasketItemData>().ToTable(nameof(StocksBasketItems));
            modelBuilder.Entity<StockData>().ToTable("Stock").Property(x => x.Price)
                .HasColumnType("decimal(16,4)");
            modelBuilder.Entity<CryptoData>().ToTable("Crypto").Property(x => x.Price)
                .HasColumnType("decimal(16,4)");
            modelBuilder.Entity<OrderData>().ToTable("Order");
            modelBuilder.Entity<OrderItemData>().ToTable("OrderItem");
            modelBuilder.Entity<CalculatorData>().ToTable("Calculator");
            modelBuilder.Entity<ATMData>().ToTable("ATM");
            modelBuilder.Entity<ATMManagerData>().ToTable("ATMManager");
            modelBuilder.Entity<AccountData>().ToTable("Account");
            modelBuilder.Entity<InvestingAccountData>().ToTable("InvestingAccount");
            modelBuilder.Entity<InvestmentData>().ToTable("Investment");
            modelBuilder.Entity<LoanData>().ToTable("Loan");
            modelBuilder.Entity<LoanAccountData>().ToTable("LoanAccount");
            modelBuilder.Entity<CarLoanData>().ToTable("CarLoan");
            modelBuilder.Entity<HomeLoanData>().ToTable("HomeLoan");
            modelBuilder.Entity<PersonalLoanData>().ToTable("PersonalLoan");
            modelBuilder.Entity<LoanManagerData>().ToTable("LoanManager");
            modelBuilder.Entity<BankData>().ToTable("Bank");
            modelBuilder.Entity<CustomerData>().ToTable("Customer");
            modelBuilder.Entity<NotificationData>().ToTable("Notification");
            modelBuilder.Entity<TransactionData>().ToTable("Transaction");
            modelBuilder.Entity<MoneyAmountData>().ToTable("MoneyAmount");
        }
    }
}
