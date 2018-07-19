using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarbageCollectorV2.Models
{
    public class DayPickUp
    {
        [Key]

        public int DayPickUpId { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }


        public string StreetAddress { get; set; }

        public int ZipCode { get; set; }

        public string PickUpDate { get; set; }

       
    }
}