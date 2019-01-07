using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Angular.Models
{
    public class CourseVM
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public string Department { get; set; }
    }
}