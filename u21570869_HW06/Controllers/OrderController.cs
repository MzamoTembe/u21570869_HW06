using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21570869_HW06.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using PagedList.Mvc;
using PagedList;

namespace u21570869_HW06.Controllers
{
    public class OrderController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();
        // GET: products
        public ActionResult Index(DateTime? date, int? i)
        {
            var orders = db.orders.Where(x => x.order_date == date || date == null).ToList().ToPagedList(i ?? 1, 5);
            return View(orders);
        }

        //public async Task<ActionResult> Index()
        //{
        //    var orders = db.orders;
        //    return View(await orders.ToListAsync());
        //}

        //[HttpPost]
        //public async Task<ActionResult> Index(DateTime date)
        //{
        //    if (date != null)
        //    {
        //        var filtered = db.orders.Where(x => x.order_date == date);
        //        return View(await filtered.ToListAsync());
        //    }
        //    else
        //    {
        //        var orders = db.orders;
        //        return View(await orders.ToListAsync());
        //    }
        //}

    }
}