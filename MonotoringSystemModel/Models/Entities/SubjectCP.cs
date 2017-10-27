﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    [Table("SubjectCPs")]
    public class SubjectCP
    {
        public SubjectCP()
        {
            CourseProjectLines = new HashSet<CourseProjectLine>();
            CPLineMaxPoints = new HashSet<CPLineMaxPoint>();
            Students = new HashSet<Student>();

            Groups = new HashSet<Group>();
        }

        [Key]
        public int SubjectCP_ID { get; set; }
        public int TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
        public string SubjectCPName { get; set; }

        [Required(ErrorMessage = "Введите № семестра"), Display(Name = "№ семестра")]
        public int Term { get; set; }

        public virtual ICollection<CourseProjectLine> CourseProjectLines { get; set; }
        public virtual ICollection<CPLineMaxPoint> CPLineMaxPoints { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}