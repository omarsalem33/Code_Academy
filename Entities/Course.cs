namespace CodeAcademy.Entities
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public int HoursToComplete { get; set; }

        public decimal Price { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();
        public ICollection<Review> Reviews { get; set; } =  new List<Review>();
    }
}
