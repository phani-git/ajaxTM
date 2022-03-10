using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BotSampleCode.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index1()
        {
            return View();
        }


        public JsonResult  myvaluefromDB()
        {

            return Json("name", JsonRequestBehavior.AllowGet);
        }
    }
}