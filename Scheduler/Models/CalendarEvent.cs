using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scheduler.Models
{
    public class CalendarEvent
    {
        public string title { get; set; }
        public DateTime start { get; set; }
        //public DateTime end { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public string textcolor { get; set; }
    }
}