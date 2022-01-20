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
        
        public DbSet<ATMData> ATMs { get; set; }
        public DbSet<ATMManagerData> ATMManagers { get; set; }
        public DbSet<AccountData> Accounts { get; set; }
        public DbSet<LoanAccountData> LoanAccounts { get; set; }
        public DbSet<LoanData> Loans { get; set; }
        public DbSet<CarLoanData> CarLoans { get; set; }
        public DbSet<HomeLoanData> HomeLoans { get; set; }
        public DbSet<PersonalLoanData> PersonalLoans { get; set; }
        public DbSet<LoanManagerData> LoanManagers { get; set; }
        public DbSet<BankData> Banks { get; set; }
        public DbSet<TransactionData> Transactions { get; set; }

        public DbSet<BlockChainData> BlockChains { get;set;}
        public DbSet<CryptoPortfolioData> CryptoPortfolios { get;set;}
        public DbSet<CryptoBasketData> CryptoBaskets { get; set; }
       
        public DbSet<CryptoBasketItemData> CryptoBasketItems { get; set; }
        public DbSet<OrderData> Orders { get; set; }
        public DbSet<OrderItemData> OrderItems { get; set; }
        public DbSet<CustomerData> Customers { get; set; }
        public DbSet<CalculatorData> Calculators { get; set; }
        
        public DbSet<CryptoData> Cryptos { get;set;}

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            InitializeTables(b);
        }
        public static void InitializeTables(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlockChainData>().ToTable(nameof(BlockChains));
            modelBuilder.Entity<CryptoBasketData>().ToTable(nameof(CryptoBaskets));
           
            modelBuilder.Entity<CryptoBasketItemData>().ToTable(nameof(CryptoBasketItems));
            
            modelBuilder.Entity<CryptoData>().ToTable(nameof(Cryptos)).Property(x => x.Price)
                .HasColumnType("decimal(16,4)");
            modelBuilder.Entity<OrderData>().ToTable(nameof(Orders));
            modelBuilder.Entity<OrderItemData>().ToTable(nameof(OrderItems));
            modelBuilder.Entity<CalculatorData>().ToTable(nameof(Calculators));
            modelBuilder.Entity<ATMData>().ToTable(nameof(ATMs));
            modelBuilder.Entity<ATMManagerData>().ToTable(nameof(ATMManagers));
            modelBuilder.Entity<CryptoPortfolioData>().ToTable(nameof(CryptoPortfolios));
            modelBuilder.Entity<AccountData>().ToTable(nameof(Accounts));
            modelBuilder.Entity<LoanData>().ToTable(nameof(Loans));
            modelBuilder.Entity<LoanAccountData>().ToTable(nameof(LoanAccounts));
            modelBuilder.Entity<CarLoanData>().ToTable(nameof(CarLoans));
            modelBuilder.Entity<HomeLoanData>().ToTable(nameof(HomeLoans));
            modelBuilder.Entity<PersonalLoanData>().ToTable(nameof(PersonalLoans));
            modelBuilder.Entity<LoanManagerData>().ToTable(nameof(LoanManagers));
            modelBuilder.Entity<BankData>().ToTable(nameof(Banks));
            modelBuilder.Entity<CustomerData>().ToTable(nameof(Customers));
            modelBuilder.Entity<TransactionData>().ToTable(nameof(Transactions));
            modelBuilder.Entity<MoneyAmountData>().ToTable("MoneyAmount");
        }
    }
}
