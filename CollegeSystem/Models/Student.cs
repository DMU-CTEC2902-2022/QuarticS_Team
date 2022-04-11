using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeSystem.Models
{
    public class Student
    {
        public virtual int StudentID { get; set; }
        public virtual string StudentName { get; set; }
        public virtual int CourseID { get; set; }
        public virtual int MoudleID { get; set; }
    }
}