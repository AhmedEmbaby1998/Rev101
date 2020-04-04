using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using rev101.Database;
using rev101.Helpers;

namespace rev101.Models.entites
{
    public class StudentRepo : IStudentRepo
    {
        public IEnumerable<Student> GetAll()
        {
            return Container.TblStudent.Students;
        }

        public Student GetStudent(int id)
        {
            return Container.TblStudent.Students.First(student => student.Id == id);
        }

        public IEnumerable<Student> RolledInAllCourses()
        {
            return Container.TblEnrolling.Enrollings.
                GroupBy(enrolling => enrolling.Student)
                .Select(grouping => grouping.Key);
        }

        public IEnumerable<Student> GetStudentsEnrolledInCourse(Course course)
        {
            return Container.TblEnrolling.Enrollings.
                Where(enrolling => enrolling.Course == course)
                .Select(enrolling => enrolling.Student);
        }

        public IEnumerable<Student> GetStudentEnrolledInCourse(int courseId)
        {
            return Container.TblEnrolling.Enrollings.
                Where(enrolling => enrolling.Course.Id == courseId)
                .Select(enrolling => enrolling.Student);
        }

        public int CountStudentEnrolledInCourse(Course course)
        {
            return Container.TblEnrolling.Enrollings.Count(enrolling => enrolling.Course == course);
        }

        public int CountStudentEnrolledInCourse(int courseId)
        {
            return Container.TblEnrolling.Enrollings.Count(enrolling => enrolling.Course.Id == courseId);
        }
    }
}