using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scheduler.Models;

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
    }
}