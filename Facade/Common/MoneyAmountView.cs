using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Facade.Common
{
	public abstract class MoneyAmountView: UniqueEntityView
	{
		[DisplayName("Money amount")] public double MoneyAmount { get; set; }
	}
}
