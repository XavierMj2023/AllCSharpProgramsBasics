﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSSQLBasics.Models;
using MSSQLBasics.Repository;

namespace MSSQLBasics.Controllers
{
    public class MSSQLController : Controller
    {
        // GET: MSSQL
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MSSQLAdd()
        {
            return View();
        }
		[HttpPost]
		public ActionResult MSSQLAdd(MSSQLAddData adddata, HttpPostedFileBase imagefile)
		{
			GetData gd = new GetData();
            gd.SaveMSSQLData(adddata,imagefile);
            ModelState.Clear();
            return View();
		}
		public ActionResult MSSQLTopics()
		{
			return View();
		}
	}
}