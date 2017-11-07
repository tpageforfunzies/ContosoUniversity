using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        //EnrollmentID will be primary key for table
        //The primary key can be default just ID or 'classname'ID which
        //is EnrollmentID in this case
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        //the foreign key and navigation property is Student
        public int StudentID { get; set; }
        //? means type will be nullable, so can not have a grade
        public Grade? Grade { get; set; }

        //This is the navigation property for CourseID
        //Only one course per Enrollment so only holds one
        public virtual Course Course { get; set; }
        //This is the navigation property for StudentID
        //Only one student per Enrollment so only holds one
        public virtual Student Student { get; set; }
    }
}