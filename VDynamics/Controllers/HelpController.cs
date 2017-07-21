using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VDynamics.Controllers
{
    public class HelpController : Controller
    {
        public ActionResult Index()
        {
			List<string> Countries = new List<string>()
			{
				"India", "China", "US", "UK"
			};

			ViewBag.Countries = Countries;

            return View ();
        }
    }
}


