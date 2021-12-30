using BankingApp.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Data
{
    public sealed class OrderItemData : UniqueEntityData
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public int Units { get; set; }
    }
}
