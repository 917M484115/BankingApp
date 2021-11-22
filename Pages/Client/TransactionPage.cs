﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Misc;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Client
{
    public sealed class TransactionPage : ViewPage<TransactionPage, ITransactionRepository, Transaction, TransactionView, TransactionData>
    {
        public TransactionPage(ITransactionRepository r) : base(r, "Transactions") { }
        protected internal override Uri pageUrl() => new Uri("/Client/Transaction/", UriKind.Relative);
        protected internal override Transaction toObject(TransactionView v) => new TransactionViewFactory().Create(v);
        protected internal override TransactionView toView(Transaction o) => new TransactionViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.RecipientId);
            createColumn(x => Item.RecipientName);
            createColumn(x => Item.SenderId);
            createColumn(x => Item.SenderName);
            createColumn(x => Item.Note);
            createColumn(x => Item.MoneyAmount);
            createColumn(x => Item.TransactionNr);
        }

        public override string GetName(IHtmlHelper<TransactionPage> h, int i) => i switch
        {
            6 => base.getName<int>(h, i),
            7 => base.getName<int>(h, i),
            _ => base.GetName(h, i)
        };

    }
}