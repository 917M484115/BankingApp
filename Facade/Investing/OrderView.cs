using BankingApp.Facade.Common;
using System;
using System.ComponentModel;
namespace BankingApp.Facade.Investing
{
    public sealed class OrderView : UniqueEntityView
    {
        [DisplayName("Customer")] public string CustomerID { get;set;}
        [DisplayName("Order date")] public DateTime OrderDate { get;set;}
        [DisplayName("Customer Name")] public string CustomerName { get;set;}
        [DisplayName("Total price")] public decimal TotalPrice { get;set;}
        public bool Closed { get;set;}
    }
}
