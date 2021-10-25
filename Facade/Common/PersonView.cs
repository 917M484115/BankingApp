using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Facade.Common
{
	public abstract class PersonView: NamedView
	{
		public int Age { get; set; }
		public DateTime? Birthday { get; set; }
		public string Country { get; set; }
	}
}
