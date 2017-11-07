using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    public class SchoolKid
    {
        public SchoolKid()
        {            
            Subjects = new HashSet<Subject>();
        }

        [Key]
        public int SchoolKidId { get; set; }

        public string ClassID { get; set; }
        public virtual Class Class { get; set; }

        [Required (ErrorMessage ="Введите имя"), Display(Name ="Имя ученика")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите отчество"), Display(Name = "Отчество ученика")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Введите фамилию"), Display(Name = "Фамилия ученика")]
        public string LastName { get; set; }
       
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
