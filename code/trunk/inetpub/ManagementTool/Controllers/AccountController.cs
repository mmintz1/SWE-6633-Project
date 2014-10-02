﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManagementTool.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return Login();
        }

        public ActionResult Login()
        {
            return View("~/Views/Account/Login.cshtml");
        }

        public ActionResult Register()
        {
            return View();
        }

    }
}
