using System.ComponentModel.DataAnnotations;
using BankingApp.Data.Common;

namespace BankingApp.Data.Investing
{
    public sealed class CalculatorData
    {
        [Key]
        public int YieldId { get; set; }
        public string YieldName { get; set; }
        public double APY { get; set; }
    }
}
