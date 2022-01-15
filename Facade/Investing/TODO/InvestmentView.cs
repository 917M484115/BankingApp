using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.Investing
{
	public sealed class InvestmentView: MoneyAmountView
	{
		[DisplayName("Current amount")] public double CurrentAmount { get; set; }
		public string Description { get; set; }
	}
}
