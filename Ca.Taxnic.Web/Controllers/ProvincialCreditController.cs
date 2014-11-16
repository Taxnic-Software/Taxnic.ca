using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ca.Taxnic.Web.Controllers
{
    public class ProvincialCreditController : Controller
    {
        //
        // GET: /ProvincialCredit/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ProvincialCredit/
        public ActionResult ClaimProvincialCredit()
        {
            return View();
        }
	}
}