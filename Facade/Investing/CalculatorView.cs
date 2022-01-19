using BankingApp.Facade.Common;
using System;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;
namespace BankingApp.Facade.Investing
{
    public sealed class CalculatorView : NamedView
    {
        [Min(0),Required]
        public double APY {get;set;}
        [Min(0)]
        public double TimeInMonths { get;set;}
        [Min(0)]
        public double Amount { get;set;}
        [Min(0)]
        public double Result { get;set;}
        [Min(0)]
        public double Revenue { get;set;}
    }
}
