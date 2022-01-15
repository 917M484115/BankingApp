using System;
using System.ComponentModel.DataAnnotations;

namespace BankingApp.Data.Common
{
    public abstract class PersonData : NamedEntityData
    {
        public int Age { get; set; }
        public string Country { get; set; }

    }
}
