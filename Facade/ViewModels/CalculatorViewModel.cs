using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Facade.ViewModels
{
    public class CalculatorViewModel
    {

        //[BindProperty]
        //[DefaultValue(1)]
        public IEnumerable<SelectListItem> YieldId { get; set; }
        public string YieldName { get; set; }

        //public IEnumerable<SelectListItem> Names { get; set; }

        //[BindProperty]
        [Required(ErrorMessage = "This field is required")]
        public double? APY { get; set; }
        
        [BindProperty, Display(Name = "Time in months"),Required(ErrorMessage ="This field is required")]
        public double? TimeInMonths { get; set; }

        [TempData, Display(Name = "Final amount")]
        public double Result { get; set; }

        [TempData]
        public double Revenue { get; set; }
        //{ get { return TimeInMonths * Amount; } }

        [BindProperty, Required(ErrorMessage = "This field is required")]
        public double? Amount { get; set; }
    }
}
