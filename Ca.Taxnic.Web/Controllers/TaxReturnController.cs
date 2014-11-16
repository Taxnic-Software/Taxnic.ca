using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ca.Taxnic.Web.Controllers
{
    public class TaxReturnController : Controller
    {
        //
        // GET: /TaxReturn/
        public ActionResult Index()
        {
            return View();
        }


        // GET: /TaxReturn/
        public ActionResult AddTaxReturn()
        {
            return View();
        }

        // GET: /TaxReturn/
        public ActionResult ImportTaxReturn()
        {
            return View();
        }

	}
}