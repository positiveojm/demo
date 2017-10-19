using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Scheduler.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DueDate { get; set; }
        public bool Status { get; set; }
    }
}