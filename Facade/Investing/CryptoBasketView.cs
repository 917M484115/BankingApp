﻿using BankingApp.Facade.Common;
using System.ComponentModel;
using DataAnnotationsExtensions;
namespace BankingApp.Facade.Investing
{
    public sealed class CryptoBasketView: UniqueEntityView
    {
        [DisplayName("Customer email")] public string CustomerID { get; set; }
        [DisplayName("Customer name")] public string CustomerName { get; set; }
        [DisplayName("Country")] public string CustomerCountry { get;set;}
        [Min(0)]
        [DisplayName("Total price")] public decimal TotalPrice { get; set; }
        [DisplayName("Closed")] public bool Closed { get; set; }
    }
}
