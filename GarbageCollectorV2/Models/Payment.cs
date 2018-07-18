using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarbageCollectorV2.Models
{
    public class Payment
    {

        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [Display(Name = "Amount Due")]
        public float AmountDue { get; set; }

        [Display(Name = "Invoice Paid")]
        public bool PaymentMade { get; set; }
    }
}