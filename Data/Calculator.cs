﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Calculator
    {
        
        [Key]
        public string YieldType { get; set; }

        //BindProperty]
        public double APY { get; set; }
        //[Required]
        [BindProperty]
        public double TimeInMonths { get; set; }
        [TempData]
        public double Result { get; set; }
        [BindProperty]
        public double Amount { get; set; }

    }
}
