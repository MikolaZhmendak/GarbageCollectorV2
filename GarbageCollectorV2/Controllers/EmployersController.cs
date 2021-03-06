﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GarbageCollectorV2.Models;

namespace GarbageCollectorV2.Controllers
{
    public class EmployersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult AllCustomers()
        {
            return View();

        }

        public ActionResult CustomerSearch()
        {
            return View(db.DayPickUp.ToList());
        }

        public JsonResult GetSearchingData(string SearchBy, string SearchValue)
        {
            List<DayPickUp> DayPick = new List<DayPickUp>();
            if (SearchBy == "PickUpDay")
            {
                try
                {
                    string Day = SearchValue;
                    DayPick = db.DayPickUp.Where(x => x.PickUpDate == Day || SearchValue == null).ToList();
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} Is Not A Valid ZipCode", SearchValue);

                }
                return Json(DayPick, JsonRequestBehavior.AllowGet);
            }
            else
            {
                DayPick = db.DayPickUp.Where(x => x.PickUpDate.Contains(SearchValue) || SearchValue == null).ToList();
                return Json(DayPick, JsonRequestBehavior.AllowGet);
            }
        }



        public ActionResult EmployerHome()
        {
            List<TodayPickUp> PickUpList = new List<TodayPickUp>();
            PickUpList = db.TodayPickUp.ToList();
            return View(PickUpList);

           
        }
        // GET: Employers
        public ActionResult Index()
        {
            return View(db.Employer.ToList());
        }

        // GET: Employers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer employer = db.Employer.Find(id);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer);
        }

        // GET: Employers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployerId,FirstName,LastName,PhoneNumber,ZipCode")] Employer employer)
        {
            if (ModelState.IsValid)
            {
                db.Employer.Add(employer);
                db.SaveChanges();
                return RedirectToAction("Home");
            }

            return View(employer);
        }

        // GET: Employers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer employer = db.Employer.Find(id);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer);
        }

        // POST: Employers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployerId,FirstName,LastName,PhoneNumber,ZipCode")] Employer employer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employer);
        }

        // GET: Employers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employer employer = db.Employer.Find(id);
            if (employer == null)
            {
                return HttpNotFound();
            }
            return View(employer);
        }

        // POST: Employers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employer employer = db.Employer.Find(id);
            db.Employer.Remove(employer);
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
    }
}
