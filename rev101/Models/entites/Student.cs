using System;

namespace rev101.Models.entites
{
    public class Student :IHasId
    {
        public int Id { get; set; }

        private static int Counter = 0;

        public string Name { set; get; }

        public int GetId() => Id;

        public string GetName()
        {
            return Name;
        }
        
        public Student(string name)
        {
            Name = name;
            Id = ++Counter;
        }

        public override string ToString()
        {
            return $"the Id is {Id}  the name is {Name}";
        }
    }
}