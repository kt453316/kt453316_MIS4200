using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace kt453316_MIS4200.Models
{
    public class Course
    {
        [Key]
        [Display (Name = "Course ID")]
        public int courseID { get; set; }
        [Display(Name = "Class Time")]
        public string classTime { get; set; }
        [Display(Name = "Instructor")]
        public string instructor { get; set; }
        [Display(Name = "Course Description")]
        public string description { get; set; }

        public ICollection<Registration> Registration { get; set; }

    }
}