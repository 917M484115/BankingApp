using BankingApp.Data.Misc;
using BankingApp.Domain.Common;

namespace BankingApp.Domain.Misc
{
	public sealed class Customer : PersonEntity<CustomerData>
	{
		public Customer(CustomerData d) : base(d) { }

	}
}
