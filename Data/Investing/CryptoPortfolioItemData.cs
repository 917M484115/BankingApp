using BankingApp.Data.Common;
namespace BankingApp.Data.Investing
{
    public sealed class CryptoPortfolioItemData : UniqueEntityData 
    {
        public string CryptoPortfolioID { get;set;}
        public string CryptoID { get;set;}
        public int Quantity { get;set;}
    }
}
