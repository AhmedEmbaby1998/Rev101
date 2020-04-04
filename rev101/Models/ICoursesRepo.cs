using System.Collections.Generic;
using rev101.Models.entites;

namespace rev101.Models
{
    public interface ICoursesRepo
    {
        IEnumerator<Course> GetAllCourses();
        IEnumerator<Course> GetCoursesOffStudent(Student student);
        IEnumerator<Course> GetCoursesOffStudent(int studentId);
    }
}