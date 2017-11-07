using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //The columns of the DB
        //ID will always default to primary key in Entity Framework
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //This is a navigation prop that will hold all "Enrollment"s
        //For a specific student
        //Is virtual for reasons (lazy-loading)
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}