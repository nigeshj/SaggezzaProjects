﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiExample.Controllers
{
    public class ProfessorController : ApiController
    {
        public List<Professor> GetProfessors()
        {
            StudentEntities ss = new StudentEntities();
            
                return ss.Professors.ToList();
            
        }
    }
}
