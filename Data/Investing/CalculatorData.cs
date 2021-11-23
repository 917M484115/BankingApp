using BankingApp.Data.Common;
using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Data.Investing
{
    public sealed class CalculatorData :NamedEntityData
    {
        public double APY { get; set; }
        [TempData]
        public double TimeInMonths { get;set;}
        [TempData]
        public double Amount { get;set;}
        [TempData]
        public double Revenue { get;set;}
        [TempData]
        public double Result { get;set;}
    }
}
