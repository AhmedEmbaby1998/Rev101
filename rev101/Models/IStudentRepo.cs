using System.Collections;
using System.Collections.Generic;
using rev101.Helpers;
using rev101.Models.entites;

namespace rev101.Models
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAll();
        Student GetStudent(int id);
        IEnumerable<Student> RolledInAllCourses();
        IEnumerable<Student> GetStudentsEnrolledInCourse(Course course);
        IEnumerable <Student>GetStudentEnrolledInCourse(int courseId);
        int CountStudentEnrolledInCourse(Course course);
        int CountStudentEnrolledInCourse(int courseId);
    }
}