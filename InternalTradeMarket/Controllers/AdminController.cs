using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternalTradeMarket.Models;
using InternalTradeMarket.ViewModels;
using PagedList;

namespace InternalTradeMarket.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;

        //connecting to the database
        public AdminController()
        {
            _context = new ApplicationDbContext();
        }

        //disposin of the database
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminLoads(string SearchString)
        {
            var loads = from r in _context.Loads
                        orderby r.DepartureCountry, r.DepartureZipCode
                        where r.UserName == SearchString || SearchString == null ||SearchString == ""
                        select r;

            return View(loads);
        }

        public ActionResult AdminDetails(int id)
        {
            var loads = _context.Loads.SingleOrDefault(c => c.Id == id);

            return View(loads);
        }

        [HttpPost]
        public ActionResult Save(Load load)
        {
            if(load.Id == 0)
            {
                _context.Loads.Add(load);
            }
            else
            {
                var loadinDB = _context.Loads.Single(c => c.Id == load.Id);

                loadinDB.DepartureCity = load.DepartureCity;
                loadinDB.DepartureZipCode = load.DepartureZipCode;
                loadinDB.DepartureCountry = load.DepartureCountry;
                loadinDB.ArrivalCountry = load.ArrivalCountry;
                loadinDB.ArrivalZipCode = load.ArrivalZipCode;
                loadinDB.ArrivalCountry = load.ArrivalCountry;
                loadinDB.PickupDate = load.PickupDate;
                loadinDB.DeliveryDate = load.DeliveryDate;
                loadinDB.Weight = load.Weight;
                loadinDB.LoadingMeter = load.LoadingMeter;
                loadinDB.ExtraComments = load.ExtraComments;
                loadinDB.Adr = load.Adr;
                loadinDB.Frigo = load.Frigo;
                loadinDB.UserName = load.UserName;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Admin");
        }
    }
}