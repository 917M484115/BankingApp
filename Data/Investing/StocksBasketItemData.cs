using BankingApp.Data.Common;

namespace BankingApp.Data.Investing
{
    public class StocksBasketItemData : UniqueEntityData
    {
        public string StockID { get; set; }
        public string StocksBasketID { get; set; }
        public int Quantity { get; set; }
    }
}
