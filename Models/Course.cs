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
        public int courseID { get; set; }
        public DateTime time { get; set; }

        public int lastName { get; set; }
        public string instructor { get; set; }
        public string description { get; set; }

        public ICollection<Registration> Registration { get; set; }
    }
}