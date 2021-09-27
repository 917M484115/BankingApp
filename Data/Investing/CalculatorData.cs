using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using BankingApp.Data.Common;

namespace Data
{
    public sealed class CalculatorData : MoneyAmountData
    {


        [Key]
        public int YieldId { get; set; }
        
        public string YieldName { get; set; }

        //BindProperty]
        public double APY { get; set; }
        //[Required]
        [BindProperty]
        public double TimeInMonths { get; set; }
        [TempData]
        public double Result { get; set; }
        //[BindProperty]
        //public double Amount { get; set; }

    }
}
