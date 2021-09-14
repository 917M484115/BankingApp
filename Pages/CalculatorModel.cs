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

namespace BankingApp.Pages
{
    public class CalculatorModel:PageModel
    {
        private readonly ApplicationDbContext _context;
        public CalculatorModel(ApplicationDbContext c) => _context = c;
        //[BindProperty] public Calculator calculator { get; private set; }
        [BindProperty] public CalculatorViewModel calculatorViewModel { get; set; }
        public SelectList FunctionNames { get; private set; }
        public void OnGet()
        {
            FunctionNames = loadYieldTypes();
        }
        public async Task<IActionResult> OnPostCalculateAsync()
        {
            calculatorViewModel.Result = calculatorViewModel.TimeInMonths * calculatorViewModel.Amount;
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

            var couch = toDataModel(calculatorViewModel);
            
            await _context.AddAsync(couch);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Calculator");
        }
        private Calculator toDataModel(CalculatorViewModel v)
        {
            var s = new Calculator();
            s.YieldType = v.YieldType;
            s.APY = v.APY;
           
            return s;
        }
        internal SelectList loadYieldTypes(object selectedType = null)
        {
            var q = from d in _context.Calculator orderby d.YieldType select d;
            return new SelectList(q.AsNoTracking(),
                "Name", "APY", selectedType);
        }
    }
}
