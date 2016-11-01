using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental.Controllers
{
    public class CustomerHistoryController : Controller
    {
        MovieRentalEntities db = new MovieRentalEntities();

        // GET: CustomerHistory
        public ActionResult Index()
        {
            var custName = from b in db.Customers
                           join r in db.RentalRecords on b.CustomerID equals r.CustomerID
                           join c in db.Movies on r.MovieID equals c.MovieID
                           select new MovieRental.Models.CustomerHistory
                           {
                               Cust = b,
                               CustMovie = c,
                               RentalDate = r.RentalDate,
                               ReturnDate = r.ReturnDate
                           };

            return View(custName);
        }

        // GET: CustomerHistory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerHistory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerHistory/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerHistory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerHistory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerHistory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerHistory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
