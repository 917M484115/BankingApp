using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Data;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Misc
{
	public sealed class Customer : PersonEntity<CustomerData>
	{
		public Customer(CustomerData d) : base(d) { }
		public string AccountId => Data?.AccountId ?? Unspecified;

	}
}
