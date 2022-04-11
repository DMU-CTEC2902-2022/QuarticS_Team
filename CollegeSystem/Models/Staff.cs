using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeSystem.Models
{
    public class Staff
    {
        public virtual int StaffID { get; set; }
        public virtual string StaffName { get; set; }
        public virtual int CourseID { get; set; }
        public virtual int ModuleID { get; set; }
    }
}