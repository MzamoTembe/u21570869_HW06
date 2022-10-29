using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21570869_HW06.Models;
using System.Data.Entity;

namespace u21570869_HW06.Controllers
{
    public class ReportController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();
        // GET: Report
        public ActionResult Index()
        {
            //List<object> iData = new List<object>();
            return View();
        }
    }
}