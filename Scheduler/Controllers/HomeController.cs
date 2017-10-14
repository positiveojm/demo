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
        public ActionResult Index()
        {
            var dbContext = new Context();
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

        public string FetchData()
        {
            var dbContext = new Context();
            List<Task> tasks = dbContext.Tasks.ToList();

            var result = GetJson(tasks);
            return result;
        }
        public string GetJson(List<Task> tasks)
        {
            string output = new JavaScriptSerializer().Serialize(tasks);
            return output;
        }
    }
}