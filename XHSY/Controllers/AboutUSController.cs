using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XHSY.Controllers
{
    public class AboutUSController : Controller
    {
        // GET: AboutUS
        public ActionResult Index(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}