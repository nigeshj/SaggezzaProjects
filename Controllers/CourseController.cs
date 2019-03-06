using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiExample.Controllers
{
    public class CourseController : ApiController
    {
        public List<Course> GetCourses()
        {
            StudentEntities ss = new StudentEntities();
            
                return ss.Courses.ToList();
            
        }

    }
}
