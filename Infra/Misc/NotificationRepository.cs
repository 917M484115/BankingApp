using BankingApp.Domain.Misc;
using BankingApp.Infra.Common;
using BankingApp.Data.Misc;
using BankingApp.Domain.Misc.Repositories;

namespace BankingApp.Infra.Misc
{
    public sealed class NotificationRepository :
        UniqueEntitiesRepository<Notification, NotificationData>, INotificationRepository
    {
        public NotificationRepository(ApplicationDbContext c) : base(c, c.Notifications) { }
        protected internal override Notification toDomainObject(NotificationData d)
            => new Notification(d);
    }
}
