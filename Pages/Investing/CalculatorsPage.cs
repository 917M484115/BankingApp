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

namespace BankingApp.Pages.Investing
{
    public sealed class CalculatorsPage : ViewPage<CalculatorsPage, ICalcuatorsRepository, Calculator, CalculatorView, CalculatorData>
    {
        public SelectList selectList;
        private readonly ApplicationDbContext _context;
        public CalculatorsPage(ICalcuatorsRepository r, ApplicationDbContext c) : base(r, "Calculator") { _context = c; selectList = new SelectList(SelectList(), "Value", "Text"); }
        public List<SelectListItem> SelectList()
        {
            var selectList = new List<SelectListItem>();
            foreach (var item in _context.Calculator)
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
        protected internal override Uri pageUrl() => new Uri("/Investing/Calculator", UriKind.Relative);
        protected internal override Calculator toObject(CalculatorView v) => new CalculatorViewFactory().Create(v);
        protected internal override CalculatorView toView(Calculator o) => new CalculatorViewFactory().Create(o);
        protected override void createTableColumns()
        {
        }
        public override string GetName(IHtmlHelper<CalculatorsPage> h, int i) => i switch
        {
            0 => getName<double>(h, i),
            _ => base.GetName(h, i)
        };
    }
}
