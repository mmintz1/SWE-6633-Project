using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagementTool.Framework.Models.Task;

namespace ManagementTool.Controllers
{
    public class TaskController : Controller
    {
        //
        // GET: /Task/

        public ActionResult Index()
        {
            return View("~/Views/Task/Tasks.cshtml");
        }

        public ActionResult Create()
        {
            var taskModel = new TaskVM();
            return View("~/Views/Task/CreateTask.cshtml", taskModel);
        }

    }
}
