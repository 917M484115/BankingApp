using BankingApp.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Data
{
    public sealed class OrderData : UniqueEntityData
    {
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
