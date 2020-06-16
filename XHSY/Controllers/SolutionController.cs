using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XHSY.Controllers
{
    public class SolutionController : Controller
    {
        // GET: Solution
        public ActionResult HospitalIndex()
        {
            return View();
        }
        public ActionResult SchoolIndex()
        {
            return View();
        }
    }
}