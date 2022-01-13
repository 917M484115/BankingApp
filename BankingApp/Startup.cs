using BankingApp.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using BankingApp.Domain;
using BankingApp.Domain.ATMs;
using BankingApp.Domain.Misc;
using BankingApp.Infra;
using BankingApp.Domain.Loans;
using BankingApp.Infra.Loan;
using BankingApp.Infra.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Infra.ATM;
using BankingApp.Infra.Misc;
using BankingApp.Domain.Common;

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
            registerRepositories(services);
            registerDbContexts(services);
            registerAuthentication(services);
            services.AddRazorPages();
            
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
            s.AddScoped<ICustomersRepository,CustomersRepository>();
            s.AddScoped<IPersonalLoanRepository, PersonalLoanRepository>();
            s.AddScoped<ICalculatorsRepository, CalculatorsRepository>();
            s.AddScoped<IInvestingAccountRepository, InvestingAccountRepository>();
            s.AddScoped<ICryptoRepository, CryptoRepository>();
            //s.AddScoped<ICryptoOrderItemsRepository, CryptoOrderItemsRepository>();
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
