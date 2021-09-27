using System;
using System.ComponentModel.DataAnnotations;

namespace BankingApp.Data.Common
{
    public abstract class PersonData : BaseData
    {
        [StringLength(50)] public string LastName { get; set; }
        [StringLength(50)] public string FirstMidName { get; set; }
        public DateTime? Birthday { get; set; }
        public byte[] Photo { get; set; }
        
    }
}
