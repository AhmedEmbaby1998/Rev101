using System;
using rev101.Helpers;
using rev101.Models.entites;

namespace rev101.Database
{
    public static  class Container
    {
        public static class  TblStudent
        {
            public static MyArrayList<Student> Students = new MyArrayList<Student>()
            {
                [1]=new Student("Ahmed Muhammed"),
                [2]=new Student("Alaa authman"),
                [3]=new Student("Nermmen Adel"),
                [4]=new Student("Khaled Osama")
            };
        }

        public static class TblCourse
        {
            public static MyArrayList<Course> Courses = new MyArrayList<Course>()
            {
                [1] = new Course("Math1"),
                [2] = new Course("Foundation"),
                [3] = new Course("Programming1")
            };
        }

        public static class TblEnrolling
        {
            public static MyArrayList<Enrolling> Enrollings = new MyArrayList<Enrolling>()
            {
               // [1] = new Enrolling(TblStudent.Students[1], TblCourse.Courses[1]),
              //  [2] = new Enrolling(TblStudent.Students[1], TblCourse.Courses[2]),
             //   [3] = new Enrolling(TblStudent.Students[1], TblCourse.Courses[3]),

                [4] = new Enrolling(TblStudent.Students[2], TblCourse.Courses[1]),
                [5] = new Enrolling(TblStudent.Students[2], TblCourse.Courses[2]),
                [6] = new Enrolling(TblStudent.Students[2], TblCourse.Courses[3]),

                [7] = new Enrolling(TblStudent.Students[3], TblCourse.Courses[1]),
                [8] = new Enrolling(TblStudent.Students[3], TblCourse.Courses[2]),
                [9] = new Enrolling(TblStudent.Students[3], TblCourse.Courses[3]),

                [10] = new Enrolling(TblStudent.Students[4], TblCourse.Courses[2]),
                
            };
        }
    }
}