using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareAPI.Controllers
{
    public class DocumentsController : Controller
    {
        private static List<Models.Document> documents = new List<Models.Document>()
        {
            new Models.Document{ ActorID = Guid.NewGuid(), ActorPropID = Guid.NewGuid(), ActorPropTitle = "Doc1", Number = 1},
            new Models.Document{ ActorID = Guid.NewGuid(), ActorPropID = Guid.NewGuid(), ActorPropTitle = "Doc2", Number = 2},
            new Models.Document{ ActorID = Guid.NewGuid(), ActorPropID = Guid.NewGuid(), ActorPropTitle = "Doc3", Number = 3}
        };
        // GET: Documents
        public ActionResult Index()
        {
            
            return View(documents);
        }

        // GET: Documents/Details/5
        public ActionResult Details(int id)
        {
            return View(documents[id]);
        }

        // GET: Documents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Documents/Create
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

        // GET: Documents/Edit/5
        public ActionResult Edit(int id)
        {
            return View(documents[id-1]);
        }

        // POST: Documents/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
             //   var ActorID = collection.GetValue("ActorID").RawValue;
                var ActorPropTitle = collection.GetValue("ActorPropTitle").RawValue;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Documents/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Documents/Delete/5
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
