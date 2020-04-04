using System.Diagnostics.Tracing;

namespace rev101.Models.entites
{
    public class Course:IHasId
    {
        public int Id { set; get; }
        
        public string CourseName { set; get; }

        private static int Counter = 0;

        public Course(string courseName)
        {
            CourseName = courseName;
            Id = ++Counter;
        }
        public int GetId() => Id;
    }
}