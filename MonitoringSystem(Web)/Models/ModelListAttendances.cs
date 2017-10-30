using MonitoringSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoringSystem_Web_.Models
{
    public class ModelListAttendances
    {
        public List<OneItemPoint> oneItemPoint { get; set; }
        public string groupId { get; set; }
        public int subjectId { get; set; }
        public string subjectName { get; set; }
        public List<Student> students { get; set; }
        public List<Attendance> attendances { get; set; }
        public List<AttendanceDate> attendanceDates { get; set; }
    }
}