using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarbageCollectorV2.Models
{
    public class Customer
    {

        [Key]
        public int CustomerId { get; set; }

        //[Display(Name = "User Name")]
        //public string UserName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        [Display(Name = "Phone#")]
        public string PhoneNumber { get; set; }


        //public List<Customer> Customers { get; set; }
        public ApplicationUser User { get; set; }

    }
}