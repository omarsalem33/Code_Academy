
namespace CodeAcademy.Entities
{
    public class Reviews
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int Feedback { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
