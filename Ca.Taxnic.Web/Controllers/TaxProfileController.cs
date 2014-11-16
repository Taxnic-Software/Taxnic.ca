using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ca.Taxnic.Web.Controllers
{
    public class TaxProfileController : Controller
    {
        //
        // GET: /TaxProfile/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /TaxProfile/
        public ActionResult CarryOver()
        {
            return View();
        }

        //
        // GET: /TaxProfile/
        public ActionResult TaxAssessment()
        {
            return View();
        }

        //
        // GET: /TaxProfile/
        public ActionResult UploadSlips()
        {
            return View();
        }

        //
        // GET: /TaxProfile/
        public ActionResult FormT1013()
        {
            return View();
        }

        //
        // GET: /TaxProfile/
        public ActionResult FormT183()
        {
            return View();
        }

        //
        // GET: /TaxProfile/
        public ActionResult CarryForward()
        {
            return View();
        }

        //
        // GET: /TaxProfile/
        public ActionResult T1Adjustment()
        {
            return View();
        }
	}
}