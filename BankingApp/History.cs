using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BankingApp
{
    public class History:Bank_services
    {
        [Key]
        DateTime Date;
        void ShowTxHistory() { }

    }
}
