using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ca.Taxnic.Web.Controllers
{
    public class DeductionsController : Controller
    {
        //
        // GET: /Deductions/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Deductions/
        public ActionResult ClaimDeduction()
        {
            return View();
        }
	}
}