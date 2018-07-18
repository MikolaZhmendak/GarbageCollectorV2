using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarbageCollectorV2.Models
{
    public class Employer
    { 
        [Key]
        public int EmployerId { get; set; } 

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone#")]
        public string PhoneNumber { get; set; }
    }
}