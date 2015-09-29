using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSiteMapProvider_MultiCategory.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Details(string id)
        {
            return View();
        }

        public ActionResult Bridal()
        {
            return View();
        }

        public ActionResult BridalRings()
        {
            return View();
        }

        public ActionResult Engagement()
        {
            return View();
        }

        public ActionResult BridalEngagement()
        {
            return View();
        }

        public ActionResult Jewelry()
        {
            return View();
        }

        public ActionResult JewelryBands()
        {
            return View();
        }

    }
}