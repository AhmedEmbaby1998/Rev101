namespace rev101.Models.entites
{
    public class Enrolling:IHasId
    {
        public int Id { set; get; }
        
        public Student Student { set; get; }
        
        public Course Course { set; get; }

        private static int _counter = 0;

        public Enrolling(Student std,Course crs)
        {
            Course = crs;
            Student = std;
            Id = ++_counter;
        } 
        public int GetId() => Id;

    }
}