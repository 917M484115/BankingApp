using BankingApp.Domain.Misc;
using BankingApp.Facade.Common;
using BankingApp.Data.Misc;
namespace BankingApp.Facade.Misc
{
	public sealed class CustomerViewFactory : AbstractViewFactory<CustomerData, Customer, CustomerView>
	{
		protected internal override Customer toObject(CustomerData d) => new Customer(d);
	}
}
