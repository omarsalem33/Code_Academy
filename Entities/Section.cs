
namespace CodeAcademy.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int? InsId { get; set; }
        public Instructor? Instructor { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }

        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }



        public ICollection<Student> Students { get; set; } = new List<Student>();
        
    }
}
