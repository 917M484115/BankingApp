using BankingApp.Data.Common;

namespace BankingApp.Data.Investing
{
    public class StocksPortfolioItemData : UniqueEntityData
    {
        public string StockID { get; set; }
        public string StocksPortfolioID { get; set; }
        public int Quantity { get; set; }
    }
}
