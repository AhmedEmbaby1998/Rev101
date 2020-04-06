using System.Collections;
using System.Collections.Generic;
using System.Linq;
using rev101.Database;
using rev101.Models.entites;

namespace rev101.Models
{
    public class CourseRepo:ICoursesRepo
    {
        public IEnumerable<Course> GetAllCourses()
        {
            return Container.TblCourse.Courses;
        }

        public IEnumerable<Course> GetCoursesOffStudent(Student student)
        {
            return Container.TblEnrolling.Enrollings.
                Where(enrolling => enrolling.Student == student)
                .Select(enrolling => enrolling.Course);
        }

        public IEnumerable<Course> GetCoursesOffStudent(int studentId)
        {
            return Container.TblEnrolling.Enrollings.
                Where(enrolling => enrolling.Student.Id == studentId)
                .Select(enrolling => enrolling.Course);        }

        public Course GetCourse(int id)
        {
            return Container.TblCourse.Courses[id];
        }

        public IEnumerable<Course> GetEmptyCourses()
        {
            var set = Container.TblEnrolling.Enrollings.Select(enrolling => enrolling.Course).ToHashSet();
            var list=new List<Course>();
            foreach (Course course in Container.TblCourse.Courses)
            {
                if (!set.Contains(course))
                {
                    list.Add(course);
                }
            }
            return list;
        }

        public int CountCourse()
        {
            return Container.TblCourse.Courses.Count;
        }
    }
}