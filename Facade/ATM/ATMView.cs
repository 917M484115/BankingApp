using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Facade.Common;

namespace BankingApp.Facade.ATM
{
	public sealed class ATMView: MoneyAmountView
	{ 
		public string Location { get; set; }
		public string Manager { get; set; }
	}
}
