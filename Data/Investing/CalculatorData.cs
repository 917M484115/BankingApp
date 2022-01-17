using BankingApp.Data.Common;
using Microsoft.AspNetCore.Mvc;

namespace BankingApp.Data.Investing
{
    public sealed class CalculatorData :NamedEntityData
    {
        public double APY { get; set; }
    }
}
