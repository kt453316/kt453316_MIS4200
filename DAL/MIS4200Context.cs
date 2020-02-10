using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using kt453316_MIS4200.Models;
using System.Data.Entity;

namespace kt453316_MIS4200.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext

    {
        public MIS4200Context() : base("name=DefaultConnection")

        {


        }


        public DbSet<Student> Student { get; set; }

        public DbSet<Registration> Registration { get; set; }

        public DbSet<Course> Course { get; set; }



    }
}