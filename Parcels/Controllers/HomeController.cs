using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ShippingParcel.Models;

namespace  ShippingParcel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}