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
using BankingApp.Domain.Investing;
using BankingApp.Infra.ATM;
using BankingApp.Infra.Misc;

namespace BankingApp
{
    public class Startup
    {
        private static string connection
            => "DefaultConnection";
        public Startup(IConfiguration c) =>Configuration=c;
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDatabaseDeveloperPageExceptionFilter();
            registerAuthentication(services);
            registerRepositories(services);
            registerDbContexts(services);
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
            s.AddScoped<IPersonalLoanRepository, PersonalLoanRepository>();
            s.AddScoped<ICalcuatorsRepository, CalculatorsRepository>();
        }

        private void registerAuthentication(IServiceCollection s)=>
            s.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
               .AddEntityFrameworkStores<ApplicationDbContext>();
        private void registerDbContexts(IServiceCollection s)
        {
            registerDbContext<DbContext>(s);
        }
        protected virtual void registerDbContext<T>(IServiceCollection s) where T : DbContext
        {
            s.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString(connection)));
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
