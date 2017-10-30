using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;
using MonitoringSystemModel;
using MonitoringSystem_Web_.Models;

namespace MonitoringSystem_Web_.Controllers
{
    [Authorize]
    public partial class SubjectsWebController : Controller
    {
        private TotalJournalContextWeb db = new TotalJournalContextWeb();
        
        protected string getUrl(string action, string groupId, int? subjectId)
        {
            string url = string.Empty;
            url = action + "/" + groupId + "/" + subjectId.ToString();
            return url;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public void getIDs(ref List<TemplateToMarks> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                int ceparatorIndex = data[i].inputId.IndexOf('_');
                data[i].inputId = data[i].inputId.Substring(0, ceparatorIndex);
            }
        }
       
        public ActionResult ShowSubjectsByCourseNumber(string classId)
        {
            List<SubjectCP> getSubjectCPs;
            if (classId != null)
            {             
               getSubjectCPs = db.SubjectCPs.ToList();                        
               ViewBag.GroupNumber = classId;
               return View(getSubjectCPs);
            }
            return View();
        }
    }
}