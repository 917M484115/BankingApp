using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Facade.Common
{
	public abstract class AccountView: MoneyAmountView
	{
        //[Required]
        [DisplayName("Account address")] 
        public string AccountAddress { get; set; }
		[DisplayName("Nickname")] public string AccountNickname { get; set; }
		[DisplayName("Customer Id")] public string CustomerId { get; set; }
		[DisplayName("Account location")] public string AccountLocation { get; set; }
	}
}
