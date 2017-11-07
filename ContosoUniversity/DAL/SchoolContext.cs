using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    public class SchoolContext
    {
        public class SchoolContext : DbContext
        {
            //This is passing the connection string into the constructor
            public SchoolContext() : base("SchoolContext")
            {
            }

            //Creates a DbSet for each entity set/type of data
            //Entity set is typically a table, so a table for each variable
            //Entity is the row/input into the table
            public DbSet<Student> Students { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<Course> Courses { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //Prevents table names from being pluralized
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }
}