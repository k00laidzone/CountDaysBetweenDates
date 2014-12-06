using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDayCountTest.Models
{
    public class NumberOfDays
    {
        [Required]
        [DisplayName("Start Date")]
        public string StartDate { set; get; }

        [Required]
        [DisplayName("End Date")]
        public string EndDate { set; get; }

        public int FinalCount { set; get; }


    }
}