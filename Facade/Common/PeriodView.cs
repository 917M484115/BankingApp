using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BankingApp.Facade.Common {

    public abstract class PeriodView {

        internal static string setDisplayNameValue => "set_DisplayNameValue";

        [DataType(DataType.Date)]
        [DisplayName("Valid From")]
        public DateTime? From { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Valid To")]
        public DateTime? To { get; set; }

        public abstract string GetId();

    }
}