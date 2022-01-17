using BankingApp.Data.Common;
using System;
namespace BankingApp.Data.Investing
{
    public sealed class OrderItemData : UniqueEntityData
    {
        public string OrderID { get; set; }
        public string CryptoID { get; set; }
        public DateTime OrderTime { get;set;}
        public string OrderType { get;set;}
        public int Units { get; set; }
    }
}
