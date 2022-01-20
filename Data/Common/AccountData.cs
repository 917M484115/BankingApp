using System;
using System.Collections.Generic;
using BankingApp.Aids.Random;

namespace BankingApp.Data.Common
{
    //TODO work on one to many relationship
    public abstract class AccountData : MoneyAmountData
    {

        public string AccountAddress { get; set; }
        public string AccountOwnerName { get; set; }
        public string AccountLocation { get; set; }


        

        //Account type?
    }
}
