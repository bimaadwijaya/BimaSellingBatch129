using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Selling.ViewModel;
using Selling.Repo;

namespace Selling.Web.Controllers
{
    public class OfficerController : Controller
    {
        tblOfficerRepo serviceOfficer = new tblOfficerRepo();
        // GET: Officer
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }
    }
}