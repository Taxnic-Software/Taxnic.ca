using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ca.Taxnic.Web.Controllers
{
    public class MessagesController : Controller
    {
        //
        // GET: /Messages/
        public ActionResult Index()
        {
            return View();
        }

        
        // GET: /Messages/
        public ActionResult AddMessage()
        {
            return View();
        }

        // GET: /Messages/
        public ActionResult Notification()
        {
            return View();
        }
	}
}