
namespace CodeAcademy.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int Feedback { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
