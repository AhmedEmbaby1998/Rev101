using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using rev101.Models;
using rev101.Models.entites;

namespace rev101.Controllers
{
    public class StudentsController:Controller
    {
        private readonly IStudentRepo _studentRepo;

        public StudentsController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public ActionResult All()
        {
            return Json(_studentRepo.GetAll());
        }
    }
}