﻿using System;
using System.Collections.Generic;
using BankingApp.Data.Investing;
using BankingApp.Data.Misc;
using BankingApp.Domain.Investing;
using BankingApp.Domain.Investing.Repositories;
using BankingApp.Domain.Misc;
using BankingApp.Domain.Misc.Repositories;
using BankingApp.Facade.Investing;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Investing
{
    public abstract class OrdersBasePage<TPage> :
        ViewPage<TPage, IOrdersRepository, Order, OrderView, OrderData>
        where TPage : PageModel
    {
        protected OrdersBasePage(IOrdersRepository r, ICustomersRepository b) : base(r, "Orders")
        {
            Customers = newItemsList<Customer, CustomerData>(b);
        }

        public IEnumerable<SelectListItem> Customers { get; }

        protected internal override Uri pageUrl()
        {
            return new("/Manager/Orders", UriKind.Relative);
        }

        public string CustomerName(string id)
        {
            return itemName(Customers, id);
        }

        protected internal override Order toObject(OrderView v)
        {
            return new OrderViewFactory().Create(v);
        }

        protected internal override OrderView toView(Order o)
        {
            return new OrderViewFactory().Create(o);
        }

        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.CustomerName);
            createColumn(x => Item.TotalPrice);
            createColumn(x => Item.OrderDate);
        }

        public override string GetName(IHtmlHelper<TPage> h, int i)
        {
            return i switch
            {
                2 => getName<decimal>(h, i),
                3 => getName<DateTime>(h, i),

                _ => base.GetName(h, i)
            };
        }

        public override IHtmlContent GetValue(IHtmlHelper<TPage> h, int i)
        {
            return i switch
            {
                2 => getValue<decimal>(h, i),
                3 => getValue<DateTime>(h, i),

                _ => base.GetValue(h, i)
            };
        }
    }
}