using Rad301ClubsV1.Models.ClubModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rad301ClubsV1.Controllers
{
    public class ClubEventController : Controller
    {
        // GET: ClubEvent
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClubEvent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClubEvent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClubEvent/Create
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

        // GET: ClubEvent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClubEvent/Edit/5
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
        public PartialViewResult _ClubEvents(int id)
        {
            using (ClubContext db = new ClubContext())
            {
                var qry = db.ClubEvents.Where(ce => ce.ClubId == id).ToList();
                return PartialView(qry);
            }
        }


        // GET: ClubEvent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClubEvent/Delete/5
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
