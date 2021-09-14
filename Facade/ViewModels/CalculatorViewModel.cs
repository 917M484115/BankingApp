using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Facade.ViewModels
{
    public class CalculatorViewModel
    {

        [Key]
        public string YieldType { get; set; }
        
        //public IEnumerable<SelectListItem> Names { get; set; }

        //[BindProperty]
        public double APY { get; set; }
        
        [BindProperty]
        public double TimeInMonths { get; set; }
        [TempData]
        public double Result { get; set; }
        //{ get { return TimeInMonths * Amount; } }
        [BindProperty]
        public double Amount { get; set; }
    }
}
