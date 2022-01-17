using BankingApp.Facade.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BankingApp.Facade.Investing
{
	public class CryptoView : VirtualAssetView 
	{
        [Required]
        [DisplayName("BlockChain")]public string BlockChainID { get;set;}
    }
}
