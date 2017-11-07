using MonitoringSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoringSystem_Web_.Models
{
    public class ModelListSubjectCPs
    {
        public List<SchoolKid> schoolKidsToShow { get; set; }
        public List<CourseProjectLine> linesToShow { get; set; }
        public List<CPLineMaxPoint> cpLinesMaxPoints { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
    }
}