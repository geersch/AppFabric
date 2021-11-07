using System;
using System.Web.Mvc;
using CGeers.Core;

namespace MvcApplication.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            var myIdentifier = (Guid?) Cache.Get("MyIdentifier");
            if (myIdentifier == null)
            {
                myIdentifier = Guid.NewGuid();
                Cache.Add("MyIdentifier", myIdentifier, new TimeSpan(0, 0, 30));
            }
            ViewData["MyIdentifier"] = myIdentifier;

            if (Session["MySessionItem"] == null)
            {
                Session["MySessionItem"] = DateTime.Now;
            }
            ViewData["MySessionItem"] = Session["MySessionItem"];

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
