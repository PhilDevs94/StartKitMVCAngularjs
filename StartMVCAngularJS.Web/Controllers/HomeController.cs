using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StartMVCAngularJS.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult App()
        {
            return PartialView();
        }
        public ActionResult Aside()
        {
            return PartialView();
        }
        public ActionResult Header()
        {
            return PartialView();
        }
        public ActionResult Dashboard()
        {
            return PartialView();
        }
        public ActionResult Setting()
        {
            return PartialView();
        }
    }
}