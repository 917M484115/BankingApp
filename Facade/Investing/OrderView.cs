using BankingApp.Facade.Common;
using System;
using System.ComponentModel;
using DataAnnotationsExtensions;
namespace BankingApp.Facade.Investing
{
    public sealed class OrderView : UniqueEntityView
    {
        [DisplayName("Customer")] public string CustomerID { get;set;}
        [DisplayName("Started Trading")] public DateTime OrderDate { get;set;}
        [DisplayName("Customer Name")] public string CustomerName { get;set;}
        [Min(0)]
        [DisplayName("Total price")] public decimal TotalPrice { get;set;}
        public bool Closed { get;set;}
    }
}
