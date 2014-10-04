using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagementTool.Framework.Models.Account;

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
            var loginModel = new LoginVM();
            return View("~/Views/Account/Login.cshtml", loginModel);
        }

        public ActionResult Register()
        {
            return View();
        }

    }
}
