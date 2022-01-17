using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;
namespace BankingApp.Facade.Common
{
	public abstract class VirtualAssetView : NamedView
    {
        [Required]
        public string Ticker { get; set; }
        [Required,Min(0)]
        public decimal Price { get; set; }
    }
}
