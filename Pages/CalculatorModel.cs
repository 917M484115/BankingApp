using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using BankingApp.Infra;
using Data;
using BankingApp.Facade.ViewModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BankingApp.Pages
{
    public class CalculatorModel:PageModel
    {
        private readonly ApplicationDbContext _context;
        public CalculatorModel(ApplicationDbContext c) => _context = c;
        //[BindProperty] public Calculator calculator { get; private set; }
        [BindProperty] public CalculatorViewModel calculatorViewModel { get; set; }
        public SelectList YieldTypes { get; private set; }
        public SelectList selectList = new SelectList(
                 new List<SelectListItem>
                 {
            new SelectListItem {Text = "Classic", Value = "0.05"},
            new SelectListItem {Text = "Risky", Value = "0.1"},
                     }, "Value", "Text");
        //public IEnumerable<SelectListItem> YieldId { get; set; }

        public IActionResult OnGet()
        {
            //YieldTypes = loadYieldTypes();
            return Page();
        }
        public IActionResult OnPost(int? id)
        {
            //YieldTypes = loadYieldTypes(id);
            return Page();
        }
        //public async Task<IActionResult> OnGetCalculateAsync(int? id)
        //{
        //    YieldTypes = loadYieldTypes(id);

        //    return Page();
        //}
        public async Task<IActionResult> OnPostCalculateAsync()
        {

            //var a = YieldTypes.SelectedValue;
            //vm.FindAsync();
            var selectedAPY = calculatorViewModel.APY+1;
            var TimeInYears = calculatorViewModel.TimeInMonths/12;
            var amount = calculatorViewModel.Amount;
            var result = amount * Math.Pow(selectedAPY, TimeInYears);
            calculatorViewModel.Result =Math.Round(result,2);
            calculatorViewModel.Revenue = Math.Round(calculatorViewModel.Result - amount,2);
            //YieldTypes = loadYieldTypes();
            return Page();
        }
        public async Task<IActionResult> OnGetCreateAsync()
        {
            
            return Page();
        }
        public async Task<IActionResult> OnPostCreateAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var yield = toDataModel(calculatorViewModel);
            
            await _context.AddAsync(yield);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Calculator");
        }
        private Calculator toDataModel(CalculatorViewModel v)
        {
            var s = new Calculator();
            s.YieldName = v.YieldName;
            s.APY = v.APY;
            s.YieldId = Convert.ToInt32(v.YieldId);
            return s;
        }
        internal SelectList loadYieldTypes(object selectedType=null)
        {
            var q = from d in _context.Calculator orderby d.YieldName select d;
            return new SelectList(q.AsNoTracking(),
                "YieldId", "YieldName", selectedType);
        }
    }
}
