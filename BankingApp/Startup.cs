using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BankingApp.Domain.ATMs;
using BankingApp.Infra;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Loan;
using BankingApp.Infra.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Infra.ATM;
using BankingApp.Infra.Misc;
using BankingApp.Domain.Common;
using BankingApp.Domain.Misc.Repositories;

namespace BankingApp
{
    public class Startup
    {
        private static string connection
            => "DefaultConnection";
        
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public Startup(IConfiguration c) => Configuration = c;
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDatabaseDeveloperPageExceptionFilter();
            registerDbContexts(services);
            registerAuthentication(services);
            services.AddRazorPages();
            registerRepositories(services);
            //services.AddTransient<IEmailSender, EmailSender>();
            //services.Configure<AuthMessageSenderOptions>(Configuration;
        }
        private static void registerRepositories(IServiceCollection s)
        {
            s.AddScoped<ITransactionRepository, TransactionRepository>();
            s.AddScoped<INotificationRepository, NotificationRepository>();
            s.AddScoped<ILoanManagerRepository, LoanManagerRepository>();
            s.AddScoped<ILoanAccountRepository, LoanAccountRepository>();
            s.AddScoped<IATMManagerRepository, ATMManagerRepository>();
            s.AddScoped<ICarLoanRepository, CarLoanRepository>();
            s.AddScoped<IHomeLoanRepository, HomeLoanRepository>();
            s.AddScoped<IPersonalLoanRepository, PersonalLoanRepository>();
            

            s.AddScoped<IBlockChainsRepository,BlockChainRepository>();
            s.AddScoped<ICryptoPortfolioRepository,CryptoPortfolioRepository>();
            s.AddScoped<ICustomersRepository, CustomersRepository>();
            s.AddScoped<ICalculatorsRepository, CalculatorsRepository>();
            s.AddScoped<ICryptoRepository, CryptoRepository>();
            s.AddScoped<IOrderItemsRepository, OrderItemsRepository>();
            s.AddScoped<IOrdersRepository,OrdersRepository>();
            s.AddScoped<ICryptoBasketItemsRepository, CryptoBasketItemsRepository>();
            s.AddScoped<ICryptoBasketsRepository, CryptoBasketRepository>();
            s.AddScoped<IStockRepository, StocksRepository>();
            GetRepository.SetServiceProvider(s.BuildServiceProvider());
        }

        private void registerDbContexts(IServiceCollection s)
        {
            registerDbContext<ApplicationDbContext>(s);
        }
        private static void registerAuthentication(IServiceCollection s)
           => s.AddDefaultIdentity<IdentityUser>(
               options => options.SignIn.RequireConfirmedAccount = true)
             .AddEntityFrameworkStores<ApplicationDbContext>();
        protected virtual void registerDbContext<T>(IServiceCollection s) where T : DbContext
        {
            s.AddDbContext<T>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString(connection)));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
