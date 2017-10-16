using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scheduler.Models;
using System.Web.Script.Serialization;

namespace Scheduler.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext = new Context();
        public ActionResult Index()
        {
            List<Task> tasks = dbContext.Tasks.ToList();

            return View(tasks);
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public Dictionary<User, List<Task>> GetUserTasks()
        //{
        //    var dbContext = new Context();
        //    List<User> users = dbContext.Users.ToList();
        //    var result = new Dictionary<User, List<Task>>();

        //    foreach(var user in users)
        //    {
        //        var tasksForUser = dbContext.Tasks.Where(x => x.UserId == user.UserId).ToList();
        //        result.Add(user, tasksForUser);                
        //    }

        //    return result;
        //}

        public string FetchData()
        {

            var eventList = new List<CalendarEvent>();
            foreach (Task t in dbContext.Tasks.ToList())
            {
                var eachEvent = new CalendarEvent { title = t.Title, description = t.Description, start = t.DueDate, color = "lime green", textcolor = "yellow",taskid =t.TaskId };
                eventList.Add(eachEvent);
            }
            var result = GetJson(eventList);
            return GetJson(eventList);
        }
        public string GetJson(List<CalendarEvent> tasks)
        {
            return new JavaScriptSerializer().Serialize(tasks);
            
        }
    }
}