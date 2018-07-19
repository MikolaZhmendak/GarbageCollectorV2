using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarbageCollectorV2.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }


        public DayOfTheWeek PickUpDay { get; set; }

        [Display(Name = "Pick Up Frequency")]
        public string PickUpFrequency { get; set; }

        [Display(Name = "Suspend Pick-Up")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? StopDate { get; set; }

        [Display(Name = "Re-Start Pick-up")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? RestartDate { get; set; }

       
        public DayOfTheWeek ExtraPickUp { get; set; }
    }

        public enum DayOfTheWeek
        {
            nopickup,
            Monday,
            Thuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
    }
