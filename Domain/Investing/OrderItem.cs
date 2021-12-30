﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Aids.Methods;
using BankingApp.Data;
using BankingApp.Data.Common;
using BankingApp.Data.Investing;
using BankingApp.Domain.Common;
using BankingApp.Domain.Investing.Repositories;

namespace BankingApp.Domain.Investing
{
    public sealed class OrderItem : UniqueEntity<OrderItemData>
    {
        public OrderItem(OrderItemData d) : base(d) { }
        public string ProductId => Data?.ProductId ?? Unspecified;
        public decimal UnitPrice => Crypto?.Price ?? UnspecifiedDecimal;
        public int Units => Data?.Units ?? UnspecifiedInteger;
        public string OrderId => Data?.OrderId ?? Unspecified;
        public  Crypto Crypto => new GetFrom<ICryptoRepository, Crypto>().ById(ProductId);
        public decimal TotalPrice => Safe.Run(() => UnitPrice * Units, decimal.MaxValue);
    }
}
