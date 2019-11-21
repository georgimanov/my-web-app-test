using System;
using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string myString, DateTime myDate)
        {
            return this.Json(new { date = myDate, value = $"from controller: {myString} - {myDate}" });
        }
    }
}
