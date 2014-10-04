using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagementTool.Framework.Models.Project;

namespace ManagementTool.Controllers
{
    public class ProjectController : Controller
    {
        //
        // GET: /Project/

        public ActionResult Index()
        {
            var projectModel = new ProjectVM();
            return View("~/Views/Project/Index.cshtml", projectModel);
        }

        public ActionResult Create()
        {
            var projectModel = new ProjectVM();
            return View("~/Views/Project/CreateProject.cshtml", projectModel);
        }

    }
}
