using System.Collections.Generic;
using rev101.Models.entites;

namespace rev101.Models
{
    public interface IStudentRepo
    {
        IEnumerator<Student> GetAll();
        Student GetStudent(int id);
        IEnumerator<Student> RolledInAllCourses();
        IEnumerator<Student> GetStudentEnrolledInCourse(Course course);
        IEnumerator<Student> GetStudentEnrolledInCourse(int courseId);
        int CountStudentEnrolledInCourse(Course course);
        int CountStudentEnrolledInCourse(int courseId);
    }
}