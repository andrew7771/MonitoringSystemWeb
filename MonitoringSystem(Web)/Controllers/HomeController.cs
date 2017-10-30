using MonitoringSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MonitoringSystem_Web_.Controllers
{
    public class HomeController : Controller
    {
        private TotalJournalContextWeb db = new TotalJournalContextWeb();
        
        public ActionResult Index()
        {
            return View(db.Classes.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult SearchStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchStudent(string RecordBookNumberID)
        {
            if (RecordBookNumberID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            SchoolKid student = db.SchoolKids.Find(RecordBookNumberID);

         
            return View("SearchStudentResults", student);
        }
    }
}
