using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactWebApp.Models
{
    public class Person
    {
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "First")]
        public String firstName { get; set; }
        [Display(Name = "Last")]
        public String lastName { get; set; }
        [Display(Name = "Email")]
        public String emailAddresses { get; set; }
        [Display(Name = "Phone")]
        public String phoneNumbers { get; set; }
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)] //date only, no time       
        public DateTime birthDay { get; set; }

        //calculated by birthday, readonly
        public long Age 
        { 
            get
            {
                return DateAndTime.DateDiff(DateInterval.Year, birthDay, DateTime.Now);
            } 
        }

    }
}
