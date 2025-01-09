using CodeAcademy.Data;
using CodeAcademy.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy.PartcipantOperation
{
    public class IndividualOperations
    {
        public static IEnumerable<Individual> RetrieveAllStudents(AppDbContext context)
        {
            using (var _context = context)
            {
                var allStudents = _context.Set<Individual>().ToList();
                // handel this case if list is empty;
                return allStudents.Any() ? allStudents : Enumerable.Empty<Individual>();
            }
        }

        public static IEnumerable<Individual> RetrieveAllStudentsIsIntern(AppDbContext context)
        {
            using (var _context = context)
            {
                var studentIsIntern = _context.Set<Individual>()
                    .Where(x => x.IsIntern)
                    .ToList();

                return studentIsIntern.Any() ? studentIsIntern:Enumerable.Empty<Individual>();
            }
        }

        public static Individual SearchUsersbyName(AppDbContext context , string FName , string LName)
        {
            using (var _context = context)
            {

                var studentName = _context.Set<Individual>()
                    .Where(x => x.FName == FName && x.LName == LName)
                    .FirstOrDefault();

                return studentName == null ? null : studentName;         
            }
        }

        public static IEnumerable<Individual>  SortingStudentsBasedOnGraduationYear(AppDbContext context)
        {
            using (var _context = context)
            {
                var allStudents = _context.Set<Individual>()
                    .OrderBy(x => x.YearOfGraduation).ToList();
                return allStudents;
            }

        }

        public static int averageGraduationYearforIndividualParticipants(AppDbContext context)
        {
            using (var _context = context)
            {
                var averageGraduationYear = _context.Set<Individual>()
                    .Average(x => x.YearOfGraduation);


                return (int) averageGraduationYear;
            }
        }

        public static void RetrieveAllStudentsParticpantinSpecificSection(AppDbContext context)
        {
            Console.Write("Enter a Section Name: ");
            var sectionName = (Console.ReadLine());

            using (var _context = context ) 
            {

                var AllStudentInSpecificSection = _context.Set<Individual>()
                   .SelectMany(x => x.Sections)
                   .Where(x => x.SectionName == sectionName)
                   .GroupBy(group => group.SectionName)
                   .Select(a => new
                   {
                       sectionName = a.Key,
                       Particpant = a.SelectMany(x => x.Participants)
                       .Select(p=> new {
                           p.Id,
                           Name = p.FName + " " + p.LName

                       }).ToList()

                   }).ToList();

                foreach (var section in AllStudentInSpecificSection)
                {
                    Console.WriteLine($"section: {section.sectionName}");
                    Console.WriteLine("Participants");
                    foreach(var Participant in section.Particpant)
                        Console.WriteLine($"\t{(Participant.Id)}\t Name: {Participant.Name} ");
                }
            }

        }

        public static void ParticipantsWithSections()
        {
            using (var _context = new AppDbContext())
            {
                var ParticipantsWithSections = _context.Particpants.AsNoTracking()
                    .Join(_context.Enrollments.AsNoTracking(),
                    p => p.Id,
                    e => e.ParticpantId,
                    (p, e) => new { p, e }).Join(_context.Sections.AsNoTracking(),
                    pe => pe.e.SectionId,
                    s => s.Id,
                    (pe, s) => new
                    {
                        Name = pe.p.FName + " " + pe.p.LName,
                        SectionName = s.SectionName
                    }).ToList();

                ParticipantsWithSections.Print("Participants With Sections");
            }
        }
    }
}
