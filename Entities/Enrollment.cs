
namespace CodeAcademy.Entities
{
    public class Enrollment
    {
        public int SectionId { get; set; }

        public int ParticpantId { get; set; }

        public Section Section { get; set; } = null!;
        public Particpant Particpant { get; set; } = null!;
    }
}
