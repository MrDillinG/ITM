using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternalTradeMarket.Models;
using InternalTradeMarket.ViewModels;
using PagedList;

namespace InternalTradeMarket.Controllers
{
    public class LoadsController : Controller
    {
        private ApplicationDbContext _context;

        //connectin to database
        public LoadsController()
        {
            _context = new ApplicationDbContext();
        }

        //Disposing of database
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Loads
        public ActionResult Loads(string dcountry, string acountry, int? page)
        {
            ViewBag.CurrentFilterA = acountry;
            ViewBag.CurrentFilterD = dcountry;
            
            ViewBag.Departurecountry = (from r in _context.Loads
                                      select r.DepartureCountry).Distinct();

            ViewBag.Arrivalcountry = (from r in _context.Loads
                                      select r.ArrivalCountry).Distinct();

            var loads = from r in _context.Loads
                        orderby r.DepartureCountry, r.DepartureZipCode
                        where r.DepartureCountry == dcountry || dcountry == null || dcountry == ""
                        where r.ArrivalCountry == acountry || acountry == null || acountry == ""
                        select r;

            int pageSize = 20;

            int pageNumber = (page ?? 1);

            return View(loads.ToPagedList(pageNumber, pageSize));
        }

        //Add Loads
        public ActionResult Add()
        {

            var viewModel = new LoadsViewModel();

            return View(viewModel);
        }

        //Save 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Load loads)
        {
            _context.Loads.Add(loads);

            _context.SaveChanges();

            return RedirectToAction("Loads", "Loads");
        }

        //View Details
        public ActionResult Details(int id)
        {
            var loads = _context.Loads.SingleOrDefault(c => c.Id == id);

            return View(loads);
        }
    }
}