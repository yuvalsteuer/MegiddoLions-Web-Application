using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MegiddoLionsWebApp.Models;

namespace MegiddoLionsWebApp.Controllers
{
    public class MembersController : Controller
    {
        private MegiddoLionsEntities db = new MegiddoLionsEntities();

        // GET: Members
        public ActionResult Index()
        {
            return View(db.tblMembers.ToList());
        }

        // GET: Members/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMember tblMember = db.tblMembers.Find(id);
            if (tblMember == null)
            {
                return HttpNotFound();
            }
            return View(tblMember);
        }

        // GET: Members/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MemberID,FirstName,LastName,JoinDate,BirthDate,PrimaryRole,SecondaryRole")] tblMember tblMember)
        {
            if (ModelState.IsValid)
            {
                db.tblMembers.Add(tblMember);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblMember);
        }

        // GET: Members/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMember tblMember = db.tblMembers.Find(id);
            if (tblMember == null)
            {
                return HttpNotFound();
            }
            return View(tblMember);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MemberID,FirstName,LastName,JoinDate,BirthDate,PrimaryRole,SecondaryRole")] tblMember tblMember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblMember).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblMember);
        }

        // GET: Members/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMember tblMember = db.tblMembers.Find(id);
            if (tblMember == null)
            {
                return HttpNotFound();
            }
            return View(tblMember);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblMember tblMember = db.tblMembers.Find(id);
            db.tblMembers.Remove(tblMember);
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
