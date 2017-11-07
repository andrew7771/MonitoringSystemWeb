using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    public class CourseProjectLine
    {
        public int CourseProjectLineID { get; set; }

        public string LineName { get; set; }
        public int LineIndex { get; set; }

        //[Index("IX_RecordBookNumberIDSubjectCP_IDTheMark", 1, IsUnique = true)]
        public int SchoolKidId { get; set; }

       // [Index("IX_RecordBookNumberIDSubjectCP_IDTheMark", 2, IsUnique = true)]
        public int SubjectID { get; set; }

        //[Index("IX_RecordBookNumberIDSubjectCP_IDTheMark", 3, IsUnique = true)]
        public int TheMark { get; set; }


        public virtual SchoolKid SchoolKid { get; set; }
        public virtual Subject Subject { get; set; }
    }
}