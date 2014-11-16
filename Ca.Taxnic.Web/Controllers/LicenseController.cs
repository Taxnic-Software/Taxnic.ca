using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ca.Taxnic.Web.Controllers
{
    public class LicenseController : Controller
    {
        //
        // GET: /License/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /License/
        public ActionResult PurchaseLicense()
        {
            return View();
        }

        //
        // GET: /License/
        public ActionResult Prices()
        {
            return View();
        }
	}
}