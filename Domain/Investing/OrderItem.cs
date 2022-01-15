﻿using BankingApp.Aids.Methods;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Domain.Investing
{
    public sealed class OrderItem : UniqueEntity<OrderItemData>
    {
        public OrderItem(OrderItemData d) : base(d) { }
        public string CryptoID => Data?.CryptoID ?? Unspecified;
        public Crypto Crypto => new GetFrom<ICryptoRepository, Crypto>().ById(CryptoID);
        public decimal UnitPrice => Crypto?.Price ?? UnspecifiedDecimal;
        public string Blockchain => Crypto?.Blockchain ?? Unspecified;
        public string Ticker => Crypto?.Ticker?? Unspecified;
        public int Units => Data?.Units ?? UnspecifiedInteger;
        public string OrderId => Data?.OrderID ?? Unspecified;
        public decimal TotalPrice => Safe.Run(() => UnitPrice * Units, decimal.MaxValue);
    }
}
