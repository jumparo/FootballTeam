using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FootballProject.Models;

namespace FootballProject.Controllers
{
    public class FootballTeamController : Controller
    {
        private MyPlayersDbContext db = new MyPlayersDbContext();

        // GET: FootballTeam
        public ActionResult Index()
        {
            return View(db.FootballTeam.ToList());
            

        }


        // GET: FootballTeam/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballTeam footballTeam = db.FootballTeam.Find(id);
            if (footballTeam == null)
            {
                return HttpNotFound();
            }
            return View(footballTeam);
        }

        // GET: FootballTeam/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FootballTeam/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,NameOfTheTeam,YearFound,Stadium,Owner,Coach,Website")] FootballTeam footballTeam)
        {
            if (ModelState.IsValid)
            {
                db.FootballTeam.Add(footballTeam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(footballTeam);
        }

        // GET: FootballTeam/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballTeam footballTeam = db.FootballTeam.Find(id);
            if (footballTeam == null)
            {
                return HttpNotFound();
            }
            return View(footballTeam);
        }

        // POST: FootballTeam/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,NameOfTheTeam,YearFound,Stadium,Owner,Coach,Website")] FootballTeam footballTeam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(footballTeam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(footballTeam);
        }

        // GET: FootballTeam/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballTeam footballTeam = db.FootballTeam.Find(id);
            if (footballTeam == null)
            {
                return HttpNotFound();
            }
            return View(footballTeam);
        }

        // POST: FootballTeam/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FootballTeam footballTeam = db.FootballTeam.Find(id);
            db.FootballTeam.Remove(footballTeam);
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
