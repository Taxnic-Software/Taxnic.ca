using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ca.Taxnic.Web.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Users/
        public ActionResult AddUser()
        {
            return View();
        }

        //
        // GET: /Users/
        public ActionResult AssignUserToRole()
        {
            return View();
        }
	}
}