using BankingApp.Facade.Common;
using System.ComponentModel;


namespace BankingApp.Facade.Investing
{
    public sealed class OrderItemView: UniqueEntityView
    {
        [DisplayName("Order")] public string OrderID { get;set;}
        [DisplayName("Crypto")] public string CryptoID { get;set;}
        [DisplayName("Crypto Name")] public string CryptoName { get;set;}
        public string BlockChain { get;set;}
        public string Ticker { get;set;}
        [DisplayName("Unit price")] public decimal UnitPrice { get;set;}
        public int Units { get;set;}
        [DisplayName("Total Price")] public decimal TotalPrice { get;set;}
    }
}
