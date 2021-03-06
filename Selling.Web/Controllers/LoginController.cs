﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Selling.ViewModel;
using Selling.Repo;

namespace Selling.Web.Controllers
{
    public class LoginController : Controller
    {
        MstUserRepo serviceUser = new MstUserRepo();
        // GET: Login
        public ActionResult Index()
        {
            //Session["Username"] = "Bima";
            return View();
        }
        [HttpPost]
        public ActionResult Login(MstUserViewModel dataLogin)
        {
            var modelUser = serviceUser.GetAll(dataLogin);
            if (modelUser.Count==0)
            {
                ViewBag.error = "Username atau Password salah";
                return View("Index");
            }
            else
            {
                if (modelUser[0].Active.ToString()=="True")
                {
                    Session["Username"]=modelUser[0].Username;
                    Session["Role"] = modelUser[0].Username;
                    Session["EmployeeName"] = modelUser[0].OfficerName;
                    return Json(new {
                    msg="success"
                    },JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new
            {
                msg = "gagal"
            }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToAction("Index", "Home");
        }
    }
}