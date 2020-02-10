using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace kt453316_MIS4200.Models
{
    public class Registration
    {
        [Key]
        public int registrationID { get; set; }



        public int studentID { get; set; }
        public virtual Student Student { get; set; }
        public int courseID { get; set; }
        public virtual Course Course { get; set; }

    }
}