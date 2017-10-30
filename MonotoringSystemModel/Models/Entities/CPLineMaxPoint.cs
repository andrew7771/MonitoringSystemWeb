using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    public class CPLineMaxPoint
    {
        public int CPLineMaxPointID { get; set; }
        public int SubjectID { get; set; }
        public string LineName { get; set; }
        public int LineIndex { get; set; }
        public int MaxPoint { get; set; }

        public virtual Subject SubjectCP { get; set; }
    }
}