using BankingApp.Facade.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
namespace BankingApp.Facade.Investing
{
	public class CryptoView : VirtualAssetView 
	{
        [DisplayName("BlockChain")]public string BlockСhainID { get;set;}
    }
}
