using MonitoringSystem_Web_.Models;
using MonitoringSystemModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace MonitoringSystem_Web_.Controllers
{
    public class SubjectsController : Controller
    {
        private TotalJournalContextWeb db = new TotalJournalContextWeb();

        // GET: SubjectCPs
        public ActionResult Index()
        {
            var subjectCPs = db.Subjects.Include(s => s.Teacher);
            return View(subjectCPs.ToList());
        }

        // GET: SubjectCPs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subjectCP = db.Subjects.Find(id);
            if (subjectCP == null)
            {
                return HttpNotFound();
            }
            return View(subjectCP);
        }

        // GET: SubjectCPs/Create
        public ActionResult Create()
        {
            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName");
            return View();
        }

        // POST: SubjectCPs/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubjectCP_ID,TeacherID,SubjectCPName,Term")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                db.Subjects.Add(subject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName", subject.TeacherID);
            return View(subject);
        }

        // GET: SubjectCPs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subjectCP = db.Subjects.Find(id);
            if (subjectCP == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName", subjectCP.TeacherID);
            return View(subjectCP);
        }

        // POST: SubjectCPs/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubjectCP_ID,TeacherID,SubjectCPName,Term")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName", subject.TeacherID);
            return View(subject);
        }

        // GET: SubjectCPs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subjectCP = db.Subjects.Find(id);
            if (subjectCP == null)
            {
                return HttpNotFound();
            }
            return View(subjectCP);
        }

        // POST: SubjectCPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subject subject = db.Subjects.Find(id);
            db.Subjects.Remove(subject);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ShowSubjects(string classId)
        {
            List<Subject> subjects;
            if (classId != null)
            {
                subjects = db.Classes.Find(classId).Subjects.ToList();
                
                ViewBag.ClassNumber = classId;
                return View(subjects);
            }
            return View();
        }

        public ActionResult ShowMarks(string classId, int? subjectId)
        {
            if (classId == null || subjectId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelListSubjectCPs model = new ModelListSubjectCPs()
            {
                schoolKidsToShow = db.SchoolKids.Where(st => st.ClassID == classId).ToList(),
                ClassName = classId,
                SubjectId = (int)subjectId,
                SubjectName = db.Subjects.Find(subjectId).SubjectName,
                linesToShow = db.CourseProjectLines.Where(cpl => cpl.SubjectID == subjectId && cpl.SchoolKid.Class.ClassID == classId).ToList(),
                cpLinesMaxPoints = db.CPLineMaxPoints.Where(cplmp => cplmp.SubjectID == subjectId).ToList()
            };
            return View(model);
        }

        public ActionResult AddCPLine(string classId, int? subjectId)
        {
            Subject subject = db.Subjects.Find(subjectId);
            List<Class> classes = subject.Classes.ToList();
            Class @class = db.Classes.Find(classId);
            int maxLineIndex = 0,
                maxId = 0,
                maxCpLineMaxPointId = 0;

            if (@class != null && @class.SchoolKids.Count == 0)
            {
                ViewBag.ErrorText = "Сначала  добавьте студентов в группу!";
                return View("Error");
            }

            var c1 = db.CourseProjectLines.Count();
            var l = db.CourseProjectLines.ToList();
            var l1 = db.CourseProjectLines.Where(m => m.Subject.SubjectID == subjectId/* && m.SchoolKid.ClassID == classId*/).ToList();
            var sch = db.SchoolKids.Where(s => s.Class.ClassID == classId).ToList();

            if (db.CourseProjectLines.Count() > 0)
            {
                maxLineIndex = db.CourseProjectLines
                .Where(m => m.Subject.SubjectID == subjectId && m.SchoolKid.ClassID == classId)
                .Max(m => m.LineIndex);
                maxId = db.CourseProjectLines.Max(m => m.CourseProjectLineID);
            }
            if (db.CPLineMaxPoints.Count() > 0)
            {
                maxCpLineMaxPointId = db.CPLineMaxPoints.Max(m => m.CPLineMaxPointID);
            }

            db.CPLineMaxPoints.Add(new CPLineMaxPoint() { CPLineMaxPointID = maxCpLineMaxPointId + 1, LineIndex = maxLineIndex + 1, MaxPoint = 0, SubjectID = (int)subjectId, LineName = "Новый этап" });

            foreach (var cls in classes)
            {
                foreach (var schoolKid in cls.SchoolKids)
                {
                    maxId++;
                    subject.CourseProjectLines.Add(new CourseProjectLine()
                    {
                        CourseProjectLineID = maxId,
                        LineIndex = (maxLineIndex + 1),
                        SchoolKidId = schoolKid.SchoolKidId,
                        SubjectID = (int)subjectId,
                        TheMark = 0,
                        LineName = "Новый этап"
                    });
                    //db.Entry(subject).State = EntityState.Added;
                    db.SaveChanges();
                }
            }
            db.SaveChanges();
            return RedirectToAction(GetUrl("ShowMarks", classId, Convert.ToInt32(subjectId)));
        }

        public ActionResult RemoveCPLine(string classId, int? subjectId)
        {
            int MaxLineIndex = 0, MaxCPLineMaxPointID = 0;
            if (db.CourseProjectLines.Count() > 0)
            {
                MaxLineIndex = db.CourseProjectLines
                                 .Where(m => m.Subject.SubjectID == subjectId && m.SchoolKid.ClassID == classId)
                                 .Max(m => m.LineIndex);
            }
            if (db.CPLineMaxPoints.Count() > 0)
            {
                MaxCPLineMaxPointID = db.CPLineMaxPoints.Max(m => m.LineIndex);
                db.CPLineMaxPoints.RemoveRange(db.CPLineMaxPoints.Where(m => m.CPLineMaxPointID == MaxCPLineMaxPointID && m.SubjectID == subjectId));
            }
            if (db.CourseProjectLines.Count() > 0)
            {
                db.CourseProjectLines.RemoveRange(db.CourseProjectLines.Where(m => m.LineIndex == MaxLineIndex && m.SubjectID == subjectId));
            }

            db.SaveChanges();
            return RedirectToAction(GetUrl("ShowMarks", classId, Convert.ToInt32(subjectId)));
        }
        [HttpPost]
        public ActionResult SaveLineName(string value, string index, string url)
        {
            int indexOfLastSlash = url.LastIndexOf('/');
            int subjectId = Convert.ToInt32(url.Substring(indexOfLastSlash + 1));
            List<CPLineMaxPoint> cpLineMaxPoints = db.CPLineMaxPoints.Where(cpl => cpl.SubjectID == subjectId).ToList();
            foreach (CPLineMaxPoint cpLineMaxPoint in cpLineMaxPoints)
            {
                if (cpLineMaxPoint.LineIndex == Convert.ToInt32(index))
                    cpLineMaxPoint.LineName = value;
            }
            List<CourseProjectLine> cpLines = db.CourseProjectLines.Where(cpl => cpl.SubjectID == subjectId).ToList();
            foreach (CourseProjectLine cpLine in cpLines)
            {
                if (cpLine.LineIndex == Convert.ToInt32(index))
                    cpLine.LineName = value;
            }
            int indexOfSubject = url.IndexOf("SubjectCPs");
            url = url.Substring(indexOfSubject);

            db.SaveChanges();
            return RedirectToAction(url);
        }
        [HttpPost]
        public ActionResult SaveChanges(List<TemplateToMarks> dataToSend)
        {
            GetIDs(ref dataToSend);
            for (int i = 0; i < dataToSend.Count - 1; i++)
            {
                switch (dataToSend[i].markType)
                {
                    case "lab":
                        CourseProjectLine mark = db.CourseProjectLines.Find(Convert.ToInt32(dataToSend[i].inputId));
                        mark.TheMark = Convert.ToInt32(dataToSend[i].inputvalue);
                        break;
                    case "maxlab":
                        CPLineMaxPoint labMaxPoint = db.CPLineMaxPoints.Find(Convert.ToInt32(dataToSend[i].inputId));
                        labMaxPoint.MaxPoint = Convert.ToInt32(dataToSend[i].inputvalue);
                        break;
                    default:
                        break;
                }
                db.SaveChanges();
            }
            string url = dataToSend[dataToSend.Count - 1].inputId.Substring(dataToSend[dataToSend.Count - 1].inputId.IndexOf("ShowMarks"));
            return RedirectToAction(url);
        }
        public void GetIDs(ref List<TemplateToMarks> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                int ceparatorIndex = data[i].inputId.IndexOf('_');
                data[i].inputId = data[i].inputId.Substring(0, ceparatorIndex);
            }
        }
        protected string GetUrl(string action, string classId, int? subjectId)
        {
            string url = string.Empty;
            url = action + "/" + classId + "/" + subjectId.ToString();
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
    }
}
