using System;
using BankingApp.Aids.Random;

namespace BankingApp.Data.Common
{
    //TODO work on one to many relationship
    public abstract class AccountData : MoneyAmountData
    {
        public string AccountAddress { get; set; }
        public string AccountNickname { get; set; } 
        public string CustomerId { get; set; }
        public string AccountLocation { get; set; }


        public void acc()
        {
            AccountAddress = accountAddress();
        }

        internal static string accountAddress() => add(digitCheckSum, generateBBAN());
        internal static string digitCheckSum() => add(countryCode, validator());

        internal static string countryCode()
        {
            return "EE";
        }

        internal static string generateBBAN()
        {
            string r = "";
            for (int i = 0; i < 16; i++)
            {
                r += GetRandom.Int32(0, 9); ;
            }
            return r;
        }

        internal static string validator()
        {
            double BBAN = double.Parse(generateBBAN());
            string r = "";
            return r;
        }

        internal static string add(Func<string> head, string tail) =>
            (isUnspecified(tail) ? head() : $"{head()}{tail}").Trim();

        //Account type?
    }
}
