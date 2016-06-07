using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Guestbook.Models;

namespace Guestbook.Controllers
{
    public class GuestbookController : Controller
    {
        private GuestbookContext _db = new GuestbookContext();

        public ActionResult Index()
        {
            var mostRecentEntries =
                (from entry in _db.Entries
                 orderby entry.DateAdded
                 select entry).Take(20);

            ViewBag.Entries = mostRecentEntries;
            return View();
        }

        public ViewResult Show(int id)
        {
            User.
            var entry = _db.Entries.Find(id);
            bool hasPermission = User.Identity.Name == entry.Name;
            ViewData["hasPermission"] = hasPermission;            
            return View(entry);
        }

        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Create(GuestbookEntry entry)
        {
            entry.DateAdded = DateTime.Now;
            _db.Entries.Add(entry);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}