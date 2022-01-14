using BankingApp.Data.Common;

namespace BankingApp.Data.Investing
{
    public sealed class OrderItemData : UniqueEntityData
    {
        public string OrderID { get; set; }
        public string CryptoID { get; set; }
        public int Units { get; set; }
    }
}
