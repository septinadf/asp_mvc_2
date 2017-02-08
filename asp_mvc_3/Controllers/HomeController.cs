﻿using asp_mvc_3.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_mvc_3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult Welcome() { return View(); }

        [AuthorizeRoles("Admin")]
        public ActionResult AdminOnly() { return View(); }
        public ActionResult UnAuthorized()
        {
            return View();
        }
    }
}