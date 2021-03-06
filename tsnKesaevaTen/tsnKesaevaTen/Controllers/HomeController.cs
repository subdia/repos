﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using tsnKesaevaTen.Models;

namespace tsnKesaevaTen.Controllers
{
    public class HomeController : Controller
    {
        Users db = new Users();

        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {

            ViewBag.Message = "О товариществе:";
            return View();
        }

        public ActionResult Contact() {

            ViewBag.Message = "Контактная информация:";
            return View();
        }

        public ActionResult Registration () {

            return View(db.UserId);
        }
    }
}