using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data;
using BankingApp.Domain.Common;

namespace BankingApp.Domain
{
	public sealed class Notification : BaseEntity<CNotificationData>
	{
		public Notification(NotificationData d) : base(d) { }
		public string CarType => Data?.CarType ?? "Unspecified";
		public string CarType => Data?.CarType ?? "Unspecified";
		public string CarType => Data?.CarType ?? "Unspecified";
		public string CarType => Data?.CarType ?? "Unspecified";
		public string CarType => Data?.CarType ?? "Unspecified";

	}
}
