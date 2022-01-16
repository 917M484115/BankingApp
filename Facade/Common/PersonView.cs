using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;
namespace BankingApp.Facade.Common
{
	public abstract class PersonView: NamedView
	{
		[Required,Min(18)]
		public int Age { get; set; }
		[Required,MinLength(3)]
		public string Country { get; set; }
	}
}
