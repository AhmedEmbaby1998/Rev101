
using Microsoft.AspNetCore.Mvc;
using rev101.Database;
using rev101.Models;
namespace rev101.Controllers
{
    public class StudentsController:Controller
    {
        private readonly IStudentRepo _studentRepo;

        public StudentsController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [Route("Students")]
        [Route("Students/All")]
        public ViewResult All()
        {
            ViewBag.title = "Information";
            return View(_studentRepo.GetAll());
        }

        public ActionResult GetStudent(int id)
        {
            var student = _studentRepo.GetStudent(id);
            ViewBag.title = student.Name;
            return View(student);
        }

        public ActionResult GetStudentsCourses()
        {
            return View(_studentRepo.RolledInAllCourses());
        }
        
        [Route("Students/CountStudentsInCourse/{courseId}")]
        public ActionResult CountStudentsInCourse(int courseId)
        {          
            ViewBag.title = "All Courses";
            ViewBag.courseName = Container.TblCourse.Courses[courseId].CourseName;
            return View(_studentRepo.CountStudentEnrolledInCourse(courseId));
        }
        
    }
}