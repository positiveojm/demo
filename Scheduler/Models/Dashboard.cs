using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scheduler.Models
{
    public class Dashboard
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public bool Status { get; set; }
        public Dictionary<int, string> NameIdMap { get; set; }
        public int UserName { get; set; }
        public int UserId { get; set; }
    }
}