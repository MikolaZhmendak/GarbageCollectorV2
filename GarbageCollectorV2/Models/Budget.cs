using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarbageCollectorV2.Models
{
    public class Budget
    {
        [Key]

        public int BudgetId { get; set; }
        public string Month { get; set; }
        public int AmountOwned { get; set; }
    }
}