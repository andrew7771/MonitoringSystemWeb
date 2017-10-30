using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    [Table("Classes")]
    public class Class
    {
        public Class()
        {
            SchoolKids = new HashSet<SchoolKid>();
            SubjectCPs = new HashSet<Subject>();
        }

        [Display(Name = "Номер класса"), Required(ErrorMessage = "Введите номер класса")]
        public string ClassID { get; set; }

        public virtual ICollection<SchoolKid> SchoolKids { get; set; }
        public virtual ICollection<Subject> SubjectCPs { get; set; }
    }

    

}