﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrivateSquareWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (ModelState.IsValid == false)
            {

                //write code to update student 

                return RedirectToAction("Index");
            }

            return View();
        }

    
        public ActionResult OTP()
        {
             return View();
        }

    }
}