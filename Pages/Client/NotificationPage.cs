using System;
using BankingApp.Data.Misc;
using BankingApp.Domain.Misc;
using BankingApp.Facade.Misc;
using BankingApp.Pages.Common;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingApp.Pages.Client
{
    public sealed class NotificationPage : ViewPage<NotificationPage, INotificationRepository, Notification, NotificationView, NotificationData>
    {
        public NotificationPage(INotificationRepository r) : base(r, "Notifications") { }
        protected internal override Uri pageUrl() => new Uri("/Client/Notification", UriKind.Relative);
        protected internal override Notification toObject(NotificationView v) => new NotificationViewFactory().Create(v);
        protected internal override NotificationView toView(Notification o) => new NotificationViewFactory().Create(o);
        protected override void createTableColumns()
        {
            createColumn(x => Item.Id);
            createColumn(x => Item.TransactionId);
            createColumn(x => Item.ATMProcessId);
            createColumn(x => Item.LoanId);
            createColumn(x => Item.InvestmentId);
            createColumn(x => Item.CurrencySwapId);
        }

        public override string GetName(IHtmlHelper<NotificationPage> h, int i) => i switch
        {
            _ => base.GetName(h, i)
        };

        public override IHtmlContent GetValue(IHtmlHelper<NotificationPage> h, int i) => i switch
        {
            _ => base.GetValue(h, i)
        };

    }
}
