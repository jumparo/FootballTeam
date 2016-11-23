using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FootballProject.Models;
public class InvalidOperationException : SystemException
{
    public InvalidOperationException(string message) : base(message)
    {
    }
}
namespace FootballProject.Controllers
{
    public class PlayersController : Controller
    {
        private MyPlayersDbContext db = new MyPlayersDbContext();

        // GET: Players
        public ActionResult Index(string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            var Players = from s in db.Players
                          select s;
            switch (sortOrder)
            {
                case "name_desc":
                    Players = Players.OrderByDescending(s => s.Name);
                    break;
                default:
                    Players = Players.OrderBy(s => s.Name);
                    break;
            }
                    return View(Players.ToList());
        }


       

        // GET: Players/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Players players = db.Players.Find(id);
            if (players == null)
            {
                return HttpNotFound();
            }
            return View(players);
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Birthday,IdNumber,BornCity,UniqueNumber,Height,Salary")] Players players)
        {
            if (ModelState.IsValid)
            {
                db.Players.Add(players);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(players);
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Players players = db.Players.Find(id);
            if (players == null)
            {
                return HttpNotFound();
            }
            return View(players);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Birthday,IdNumber,BornCity,UniqueNumber,Height,Salary")] Players players)
        {
            if (ModelState.IsValid)
            {
                db.Entry(players).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(players);
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Players players = db.Players.Find(id);
            if (players == null)
            {
                return HttpNotFound();
            }
            return View(players);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Players players = db.Players.Find(id);
            db.Players.Remove(players);
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
