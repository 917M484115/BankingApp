namespace BankingApp.Data.Common
{
    public abstract class VirtualAssetData : NamedEntityData
    {
        public string Ticker {get;set;}
        public decimal Price { get;set;}
    }
}
