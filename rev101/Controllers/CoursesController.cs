using Microsoft.AspNetCore.Mvc;
using rev101.Models;

namespace rev101.Controllers
{
    public class CoursesController : Controller
    {
        private ICoursesRepo _repo;

        public CoursesController(ICoursesRepo repo)
        {
            _repo = repo;
        }

        public ActionResult All()
        {
            ViewBag.title = "All Courses";
            return View(_repo.GetAllCourses());
        }

        public ActionResult EmptyCourses()
        {
            ViewBag.title = "All Courses";
            return View(_repo.GetEmptyCourses());
        }

        [Route("Courses/CoursesOfStudents/{studentId}")]
        public ActionResult CoursesOfStudents(int studentId)
        {
            return View(_repo.GetCoursesOffStudent(studentId));
        }

    }
}