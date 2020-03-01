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
        [Required]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Display(Name = "Phone")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }

        public ICollection<Registration> Registration { get; set; }



    }
}