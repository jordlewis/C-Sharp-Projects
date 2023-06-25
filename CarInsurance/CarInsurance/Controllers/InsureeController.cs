using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // This istanstiates the quote at $50
                decimal monthlyQuote = 50m;
                /// This calculates the age of the insuree by years
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                // This checks if the user's age is younger than 18 years, then adds $100 to the monthly quote
                if (age < 18)
                {
                    monthlyQuote += 100m;
                }
                // This checks if the user's age is less than 25 years, but older than 18 years and if so, adds $50 to the monthly quote
                else if (age < 25)
                {
                    monthlyQuote += 50m;
                }
                // This checks if the user's age is older than 26 years and adds $25 to the monthly quote
                else if (age > 26)
                {
                    monthlyQuote += 25m;
                }
                // This checks if the insuree's car was manufactured before the year 2000, and adds $25 to the monthly quote if so
                if (insuree.CarYear < 2000)
                {
                    monthlyQuote += 25m;
                }
                // This checks if the insuree's car was manufactured after the year 2015, and adds $25 to the monthly quote if so
                else if (insuree.CarYear > 2015)
                {
                    monthlyQuote += 25m;
                }
                // This checks if the insuree's car is a Porsche and if so adds $25 to the monthly quote
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    monthlyQuote += 25m;
                    // AND if the model is '911 Carrera' and adds an additional $25 to the monthly quote
                    if (insuree.CarModel.ToLower() == "911 carrera")
                    {
                        monthlyQuote += 25m;
                    }
                }
                // This adds $10 to the monthly total for every speeding ticket the user has
                if (insuree.SpeedingTickets > 0)
                {
                    monthlyQuote += insuree.SpeedingTickets * 10m;
                }
                // If the user has ever had a DUI, the total increases by 25%
                if (insuree.DUI)
                {
                    monthlyQuote *= 1.25m;
                }
                // If it's full coverage, the total increases by 50% 
                if (insuree.CoverageType)
                {
                    monthlyQuote *= 1.5m;
                }

                // This sets the variable unique 'monthlyQuote' to the insuree
                insuree.Quote = monthlyQuote;

                // This adds the insuree to the database
                db.Insurees.Add(insuree);

                // This saves the changes to the insuree
                db.SaveChanges();

                // This redirects to the index view
                return RedirectToAction("Index");
            }

            return View(insuree);
        }



        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType, Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Admin()
        {
            var allQuotes = db.Insurees.ToList();
            return View(allQuotes);
        }
    }
}