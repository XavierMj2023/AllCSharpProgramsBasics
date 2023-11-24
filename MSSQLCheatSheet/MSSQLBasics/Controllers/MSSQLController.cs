using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSSQLBasics.Models;

namespace MSSQLBasics.Controllers
{
    public class MSSQLController : Controller
    {
        // GET: MSSQL
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MSSQLAdd()
        {
            return View();
        }
		[HttpPost]
		public ActionResult MSSQLAdd(MSSQLAddData adddata)
		{

			return View();
		}
		public ActionResult MSSQLTopics()
		{
			return View();
		}
	}
}