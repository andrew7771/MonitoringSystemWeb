using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    public class Subject
    {
        public Subject()
        {
            CourseProjectLines = new HashSet<CourseProjectLine>();
            CPLineMaxPoints = new HashSet<CPLineMaxPoint>();
            SchoolKids = new HashSet<SchoolKid>();
            Classes = new HashSet<Class>();
        }

        [Key]
        public int SubjectID { get; set; }
        public int TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<CourseProjectLine> CourseProjectLines { get; set; }
        public virtual ICollection<CPLineMaxPoint> CPLineMaxPoints { get; set; }
        public virtual ICollection<SchoolKid> SchoolKids { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}