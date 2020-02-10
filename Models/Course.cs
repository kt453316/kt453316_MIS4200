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
        public DateTime classTime { get; set; }        public int instructor { get; set; }        public int description { get; set; }        public ICollection<Registration> Registration { get; set; }
    }
}