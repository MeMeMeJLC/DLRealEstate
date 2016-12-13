using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dlrealestate3.Models;

namespace dlrealestate3.Controllers
{
    public class LocalHistoryController : Controller
    {
        private dlrealestate3Context db = new dlrealestate3Context();

        // GET: LocalHistory
        public async Task<ActionResult> Index()
        {
            return View(await db.LocalHistories.ToListAsync());
        }

        // GET: LocalHistory/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalHistory localHistory = await db.LocalHistories.FindAsync(id);
            if (localHistory == null)
            {
                return HttpNotFound();
            }
            return View(localHistory);
        }

        // GET: LocalHistory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocalHistory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Title,ImageUrl,Content,KeyWord,DatePublished")] LocalHistory localHistory)
        {
            if (ModelState.IsValid)
            {
                db.LocalHistories.Add(localHistory);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(localHistory);
        }

        // GET: LocalHistory/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalHistory localHistory = await db.LocalHistories.FindAsync(id);
            if (localHistory == null)
            {
                return HttpNotFound();
            }
            return View(localHistory);
        }

        // POST: LocalHistory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Title,ImageUrl,Content,KeyWord,DatePublished")] LocalHistory localHistory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(localHistory).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(localHistory);
        }

        // GET: LocalHistory/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalHistory localHistory = await db.LocalHistories.FindAsync(id);
            if (localHistory == null)
            {
                return HttpNotFound();
            }
            return View(localHistory);
        }

        // POST: LocalHistory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            LocalHistory localHistory = await db.LocalHistories.FindAsync(id);
            db.LocalHistories.Remove(localHistory);
            await db.SaveChangesAsync();
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
