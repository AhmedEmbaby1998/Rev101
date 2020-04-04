using System;
using rev101.Models;
using rev101.Models.entites;

namespace rev101.Testing
{
    public class TestStudentRepo1
    {
        private IStudentRepo _repo;

        public TestStudentRepo1(IStudentRepo repo)
        {
            this._repo = repo;
        }

        public void PrintGetAll()
        {
            foreach (var st in _repo.GetAll())
            {
                Console.WriteLine($"student Id is {st.Id} and Name is {st.Name}");
            }
        }

        public void PrintRolledInAllCourses()
        {
            foreach (var st in _repo.RolledInAllCourses())
            {
                Console.WriteLine($"student Id is {st.Id} and Name is {st.Name}");
            }
        }

        public void PrintGetStudent(int id)
        {
            var st = _repo.GetStudent(id);
            Console.WriteLine($"student Id is {st.Id} and Name is {st.Name}");
        }

        public void PrintGetStudentsEnrolledInCourse(Course course)
        {
            foreach (var st in _repo.GetStudentsEnrolledInCourse(course))
            {
                Console.WriteLine($"student Id is {st.Id} and Name is {st.Name}");
            }
        }

        public void PrintGetStudentsEnrolledInCourse(int courseId)
        {
            foreach (var st in _repo.GetStudentEnrolledInCourse(courseId))
            {
                Console.WriteLine($"student Id is {st.Id} and Name is {st.Name}");
            }
        }

        public void PrintCountStudentEnrolledInCourse(Course course)
        {
            var cnt = _repo.CountStudentEnrolledInCourse(course);
            Console.WriteLine($"Count is {cnt}");
        }

        public void PrintCountStudentEnrolledInCourse(int courseId)
        {
            var cnt = _repo.CountStudentEnrolledInCourse(courseId);
            Console.WriteLine($"Count is {cnt}");
        }

    }
}