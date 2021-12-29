using BankingApp.Data.Common;
namespace BankingApp.Data.Investing
{
    public sealed class CryptoBasketItemData : UniqueEntityData 
    {
        public string CryptoBasketID { get;set;}
        public string CryptoID { get;set;}
        public int Quantity { get;set;}
    }
}
