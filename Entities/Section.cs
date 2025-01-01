using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Entities
{
    public class Section
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? InsId { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public Instructor? Instructor { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<SectionSchedule> SectionSchedules { get; set; } = new List<SectionSchedule>();
    }
}
