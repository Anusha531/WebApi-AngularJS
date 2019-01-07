using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Angular.Models;

namespace WebAPI_Angular.Controllers.Api
{
    public class CoursesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<CourseVM> Get()
        {
            using (var db = new UNContext())
            {
                var obj = db.Courses.Select(c => new CourseVM
                {
                    CourseID = c.CourseID,
                    Title = c.Title,
                    Credits = c.Credits,
                    Department = c.Department.Name
                }).ToList();

                return obj;

            }
        }
    }
}
