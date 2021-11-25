﻿using BankingApp.Data.Common;

namespace BankingApp.Data.Loan
{
    public class LoanData : MoneyAmountData
    {
        public int LoanPeriod { get; set; }
        public double Interest { get; set; }
        public string LoanManagerId { get; set; }

    }
}
