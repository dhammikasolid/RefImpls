using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Basic.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetParam1(int p)
        {
            return Json(new { Value = p + 1 }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetParam2(int p)
        {
            return Json(new { Value = p + 1 }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetResource(int p1, int p2)
        {
            return Json(new { Value = p1 + p2 }, JsonRequestBehavior.AllowGet);
        }

    }
}