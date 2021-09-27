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
        public SelectList selectList; 
        //public IEnumerable<SelectListItem> YieldId { get; set; }
        public List<SelectListItem> SelectList ()
        {
              List<SelectListItem>selectList=new List<SelectListItem>();
              foreach(var item in _context.Calculator)
              { 
                selectList.Add(new SelectListItem {Text=item.YieldName.ToString(),Value=item.APY.ToString() });
              }
              return selectList;
        }
        public IActionResult OnGet()
        {
            selectList = new SelectList(SelectList(), "Value", "Text");
            return Page();
        }
        public IActionResult OnPost(int? id)
        {
            return Page();
        }
        public async Task<IActionResult> OnGetCalculateAsync(int? id)
        {
            selectList = new SelectList(SelectList());
            return Page();
        }
        public async Task<IActionResult> OnPostCalculateAsync()
        {
            //var a = YieldTypes.SelectedValue;
            //vm.FindAsync();
            selectList = new SelectList(SelectList(), "Value", "Text");
            var selectedAPY = Convert.ToDouble(calculatorViewModel.APY)+1;
            var TimeInYears = Convert.ToDouble(calculatorViewModel.TimeInMonths)/12;
            var amount = Convert.ToDouble(calculatorViewModel.Amount);
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
        private CalculatorData toDataModel(CalculatorViewModel v)
        {
            var s = new CalculatorData();
            s.YieldName = v.YieldName;
            s.APY = Convert.ToDouble(v.APY);
            s.YieldId = Convert.ToInt32(v.YieldId);
            return s;
        }
    }
}
