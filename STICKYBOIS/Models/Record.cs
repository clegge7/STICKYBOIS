using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace STICKYBOIS.Models
{
    public class StickyBoisContext : DbContext
    {
        public DbSet<Record> Records { get; set; }
    }

    public class Record
    {
        public int id { get; set; }

        [Display(Name = "Start Time")]
        public string StartTime { get; set; }

        [Display(Name = "Fall Time")]
        public string EndTime { get; set; }

        [Display(Name = "Total Time Up")]
        public string TotalTime { get; set; }

        [Display(Name = "Thrower")]
        public string Thrower { get; set; }

    }
}