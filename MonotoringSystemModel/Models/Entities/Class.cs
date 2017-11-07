using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    public class Class
    {
        public Class()
        {
            SchoolKids = new HashSet<SchoolKid>();
            Subjects = new HashSet<Subject>();
        }

        [Display(Name = "Номер класса"), Required(ErrorMessage = "Введите номер класса")]
        public string ClassID { get; set; }

        public virtual ICollection<SchoolKid> SchoolKids { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }    

}