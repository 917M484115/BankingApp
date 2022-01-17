using BankingApp.Facade.Common;
using System.ComponentModel;
using System;
using DataAnnotationsExtensions;
namespace BankingApp.Facade.Investing
{
    public sealed class OrderItemView: UniqueEntityView
    {
        [DisplayName("Order")] public string OrderID { get;set;}
        [DisplayName("Crypto")] public string CryptoID { get;set;}
        [DisplayName("Crypto Name")] public string CryptoName { get;set;}
        [DisplayName("Order Date")] public DateTime OrderTime { get;set;}
        [DisplayName("Order Type")] public string OrderType { get;set;}
        public string BlockChain { get;set;}
        public string Ticker { get;set;}
        [Min(0)]
        [DisplayName("Unit price")] public decimal UnitPrice { get;set;}
        [Min(0)]
        public int Units { get;set;}
        [Min(0)]
        [DisplayName("Total Price")] public decimal TotalPrice { get;set;}
    }
}
