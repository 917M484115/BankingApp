using BankingApp.Data.Investing;
using BankingApp.Data.Misc;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Pages.Investing
{
    public abstract class CryptoBasketBasePage<TPage> :
        ViewPage<TPage, ICryptoBasketsRepository, CryptoBasket, 
            CryptoBasketView, CryptoBasketData>
        where TPage : PageModel
    {
        public IEnumerable<SelectListItem> Buyers { get; }
        public IOrdersRepository Orders { get; }
        public ICryptoOrderItemsRepository OrderItems { get; }
        protected CryptoBasketBasePage(ICryptoBasketsRepository r, ICustomerRepository b,
            IInvestmentRepository o, ICryptoOrderItemsRepository oi) : base(r, "Baskets")
        {
            Buyers = newItemsList<Customer, CustomerData>(b);
            Orders = (IOrdersRepository)o;
            OrderItems = oi;
        }
    }
}
