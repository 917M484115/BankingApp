﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BankingApp
{
    public class Customer
    {
        [Key]
        int CustomerId;
        double AccountBalance;
        string UserName;
        string Password;
       
    }
}
