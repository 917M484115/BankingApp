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
        //public IEnumerable<SelectListItem> YieldId { get; set; }
        public IActionResult OnGet()
        {
            YieldTypes = loadYieldTypes(new object[] { "Classic", 0.01, 0, 0, 0, 1 });
            return Page();
        }
        public IActionResult OnPost()
        {
            //YieldTypes = loadYieldTypes();
            return Page();
        }
        public async Task<IActionResult> OnGetCalculateAsync()
        {
            YieldTypes = loadYieldTypes(new object[] { "Classic", 0.01, 0, 0, 0, 1 });
            
            return Page();
        }
        public async Task<IActionResult> OnPostCalculateAsync()
        {
           
            var a = YieldTypes;
            var selectedAPY =calculatorViewModel.YieldId;
            calculatorViewModel.Result =Convert.ToDouble(selectedAPY);
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
        internal SelectList loadYieldTypes(object selectedType)
        {
            var q = from d in _context.Calculator orderby d.YieldName select d;
            return new SelectList(q.AsNoTracking(),
                "YieldId", "YieldName", selectedType);
        }
    }
}
