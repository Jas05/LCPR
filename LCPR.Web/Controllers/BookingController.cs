﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LCPR.Web.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ValidateUser(string bookingRef, string surname)
        {

            return RedirectToAction("Index", "Details");
        }


    }
}