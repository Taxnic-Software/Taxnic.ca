using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ca.Taxnic.Web.Controllers
{
    public class HelpController : Controller
    {
        //
        // GET: /Help/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Help/
        public ActionResult TaxTips()
        {
            return View();
        }

        //
        // GET: /Help/
        public ActionResult CraLinks()
        {
            return View();
        }

        //
        // GET: /Help/
        public ActionResult Support()
        {
            return View();
        }
	}
}