using System.Collections;
using System.Collections.Generic;
using rev101.Models.entites;

namespace rev101.Models
{
    public interface ICoursesRepo
    {
        IEnumerable<Course> GetAllCourses();
        IEnumerable<Course> GetCoursesOffStudent(Student student);
        IEnumerable<Course> GetCoursesOffStudent(int studentId);
        Course GetCourse(int id);
        IEnumerable<Course> GetEmptyCourses();
        int CountCourse();
    }
}