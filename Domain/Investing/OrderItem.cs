using BankingApp.Aids.Methods;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing.Repositories;
using System;
namespace BankingApp.Domain.Investing
{
    public sealed class OrderItem : UniqueEntity<OrderItemData>
    {
        public OrderItem(OrderItemData d) : base(d) { }
        public string CryptoID => Data?.CryptoID ?? Unspecified;
        public Crypto Crypto => new GetFrom<ICryptoRepository, Crypto>().ById(CryptoID);
        public decimal UnitPrice => Crypto?.Price ?? UnspecifiedDecimal;
        public string Blockchain => Crypto?.BlockChainID ?? Unspecified;
        public string Ticker => Crypto?.Ticker?? Unspecified;
        public int Units => Data?.Units ?? UnspecifiedInteger;
        public DateTime OrderTime => Data?.OrderTime ?? UnspecifiedValidTo;
        public string OrderID => Data?.OrderID ?? Unspecified;
        public decimal TotalPrice => Safe.Run(() => UnitPrice * Units, decimal.MaxValue);
    }
}
