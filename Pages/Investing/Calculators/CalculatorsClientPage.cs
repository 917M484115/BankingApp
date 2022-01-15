using BankingApp.Pages.Common;
using BankingApp.Domain.Investing;
using BankingApp.Facade.Investing;
using BankingApp.Data.Investing;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using BankingApp.Infra;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BankingApp.Domain.Investing.Repositories;
namespace BankingApp.Pages.Investing
{
    public sealed class CalculatorsClientPage : CalculatorsBasePage<CalculatorsClientPage>
    {
        public SelectList selectList;
        private readonly ApplicationDbContext _context;
        public CalculatorsClientPage(ICalculatorsRepository r, ApplicationDbContext c) : base(r) { _context = c; selectList = new SelectList(SelectList(), "Value", "Text"); }
        public List<SelectListItem> SelectList()
        {
            var selectList = new List<SelectListItem>();
            foreach (var item in _context.Calculators)
                selectList.Add(new SelectListItem { Text = item.Name, Value = item.APY.ToString() });
            return selectList;
        }
        public async Task<IActionResult> OnPostCalculateAsync()
        {
           var selectedAPY = Convert.ToDouble(Item.APY) + 1;
           var TimeInYears = Convert.ToDouble(Item.TimeInMonths) / 12;
           var amount = Convert.ToDouble(Item.Amount);
           var result = amount * Math.Pow(selectedAPY, TimeInYears);
           Item.Result = Math.Round(result, 2);
           Item.Revenue = Math.Round(Item.Result - amount, 2);
           return Page();
        }
        protected internal override Uri pageUrl() => new Uri("/Customer/Calculators", UriKind.Relative);
    }
}
