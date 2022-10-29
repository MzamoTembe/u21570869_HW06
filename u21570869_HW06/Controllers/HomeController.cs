using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21570869_HW06.Models;

namespace u21570869_HW06.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}