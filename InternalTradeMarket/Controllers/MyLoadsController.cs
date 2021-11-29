using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternalTradeMarket.Models;

namespace InternalTradeMarket.Controllers
{
    public class MyLoadsController : Controller
    {
        private ApplicationDbContext _context;

        //Connecting to the database
        public MyLoadsController()
        {
            _context = new ApplicationDbContext();
        }

        //Disposing of the database
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: MyLoads
        public ActionResult Index()
        {
            var loads = _context.Loads;

            return View(loads);
        }

        // Edit loads
        public ActionResult Edit(int id)
        {
            var loads = _context.Loads.SingleOrDefault(c => c.Id == id);

            return View(loads);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Load load)
        {
            if(load.Id == 0)
                _context.Loads.Add(load);
            else
            {
                var CustomerinDB = _context.Loads.Single(c => c.Id == load.Id);

                CustomerinDB.DepartureCity = load.DepartureCity;
                CustomerinDB.DepartureZipCode = load.DepartureZipCode;
                CustomerinDB.DepartureCountry = load.DepartureCountry;
                CustomerinDB.ArrivalCountry = load.ArrivalCountry;
                CustomerinDB.ArrivalZipCode = load.ArrivalZipCode;
                CustomerinDB.ArrivalCountry = load.ArrivalCountry;
                CustomerinDB.PickupDate = load.PickupDate;
                CustomerinDB.DeliveryDate = load.DeliveryDate;
                CustomerinDB.Weight = load.Weight;
                CustomerinDB.LoadingMeter = load.LoadingMeter;
                CustomerinDB.ExtraComments = load.ExtraComments;
                CustomerinDB.Adr = load.Adr;
                CustomerinDB.Frigo = load.Frigo;
            }


            _context.SaveChanges();

            return RedirectToAction("Index", "MyLoads");
        }

        // Remove Loads
        public ActionResult Remove(int id)
        {
            var remove = _context.Loads.Single(o => o.Id == id);

            _context.Loads.Remove(remove);

            _context.SaveChanges();

            return RedirectToAction("Index", "MyLoads");
        }
    }
}