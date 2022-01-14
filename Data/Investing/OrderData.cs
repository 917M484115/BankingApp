using BankingApp.Data.Common;
using System;

namespace BankingApp.Data.Investing
{
    public sealed class OrderData : UniqueEntityData
    {
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
