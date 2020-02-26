using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace kt453316_MIS4200.Models
{
    public class Student
    {
        [Key]
        [Display(Name = "Student ID")]
        public int studentID { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Phone")]
        public string phone { get; set; }

        public ICollection<Registration> Registration { get; set; }



    }
}