using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiExample.Controllers
{
    public class StudentController : ApiController
    {
        public List<Student> GetStudents()
        {
            using (StudentEntities ss = new StudentEntities())
            {
                return ss.Students.ToList();
            }
        }
    }
}
