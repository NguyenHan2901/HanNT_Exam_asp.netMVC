using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procedure.Controllers
{
    public class ProcedureController : Controller
    {
        ProcedureEntities db = new ProcedureEntities();
        // GET: Procedure
        public ActionResult Index()
        {
            return View(db.Procedures.ToList());
        }

        // GET: Procedure/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Procedure/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Procedure/Create
        [HttpPost]
        public ActionResult Create(Procedure procedure)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.Procedures.Add(procedure);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(procedure);

            }
            catch
            {
                return View();
            }
        }

        // GET: Procedure/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Procedure/Edit/5
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

        // GET: Procedure/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Procedure/Delete/5
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
