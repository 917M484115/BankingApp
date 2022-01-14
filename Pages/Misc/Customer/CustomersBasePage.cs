using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
using BankingApp.Facade.Misc;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Pages.Misc
{
    public abstract class CustomersBasePage<TPage> :
        ViewPage<TPage, ICustomersRepository, Customer, CustomerView, CustomerData>
        where TPage : PageModel
    {     
        protected CustomersBasePage(ICustomersRepository r) : base(r, "Customers") { }
        protected internal override Customer toObject(CustomerView v) => new CustomerViewFactory().Create(v);
        protected internal override CustomerView toView(Customer o) => new CustomerViewFactory().Create(o);
    }
}
