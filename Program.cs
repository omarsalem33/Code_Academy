using CodeAcademy.Data;
using CodeAcademy.Entities;
using Microsoft.EntityFrameworkCore;
using System.Buffers.Text;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeAcademy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region SeedingData
            //using(var context = new AppDbContext()) 
            //{
            //     await context.Database.EnsureCreatedAsync();

            //     if (!await context.Set<Individual>().AnyAsync())
            //     {
            //         context.Set<Individual>().AddRange(SeedData.LoadIndividuals());
            //     }
            //     if (!await context.Set<Coporate>().AnyAsync())
            //     {
            //         context.Set<Coporate>().AddRange(SeedData.LoadCorporates());
            //     }
            //     if (!await context.Set<Course>().AnyAsync())
            //     {
            //         context.Set<Course>().AddRange(SeedData.LoadCourses());
            //     }
            //     if (!await context.Set<Office>().AnyAsync())
            //     {
            //         context.Set<Office>().AddRange(SeedData.LoadOffices());
            //     }
            //     if (!await context.Set<Schedule>().AnyAsync())
            //     {
            //         context.Set<Schedule>().AddRange(SeedData.LoadSchedules());
            //     }
            //     if (!await context.Set<Instructor>().AnyAsync())
            //     {
            //         context.Set<Instructor>().AddRange(SeedData.LoadInstructors());
            //     }
            //     if (!await context.Set<Section>().AnyAsync())
            //     {
            //         context.Set<Section>().AddRange(SeedData.LoadSections());
            //     }
            //     if (!await context.Set<Enrollment>().AnyAsync())
            //     {
            //         context.Set<Enrollment>().AddRange(SeedData.LoadEnrollments());
            //     }
            //     if (!await context.Set<TrueAndFalseQuiz>().AnyAsync())
            //     {
            //         context.Set<TrueAndFalseQuiz>().AddRange(SeedData.LoadTrueAndFalseQuizzes());
            //     }
            //     if (!await context.Set<MultipleChoiceQuiz>().AnyAsync())
            //     {
            //         context.Set<MultipleChoiceQuiz>().AddRange(SeedData.LoadMultipleChoiceQuizzes());
            //     }
            //     await context.SaveChangesAsync();
            // }
            #endregion

            #region Split Query
            //using (var _context = new AppDbContext())
            //{
            //    //// proper projection (select) reduce network traffic
            //    //// and reduce the effect on app performance
            //    //var courses = _context.Courses.AsNoTracking()
            //    //    .Select(c => new
            //    //    {
            //    //        CourseId = c.Id,
            //    //        CourseName = c.CourseName,
            //    //        Hours = c.HoursToComplete,
            //    //        Section = c.Sections.Select(s => new
            //    //        {
            //    //            SectionId = s.Id,
            //    //            SectionName = s.SectionName,
            //    //            DateRange = s.DateRange.ToString(),
            //    //            TimeSlot = s.TimeSlot.ToString()
            //    //        }),
            //    //        Review = c.Reviews.Select(r => new
            //    //        {
            //    //            FeedBack = r.Feedback,
            //    //            CreatedAT = r.CreatedAt
            //    //        })
            //    //    }).ToList();
            //}

            //using (var _context = new AppDbContext())
            //{
            //    var courses = _context.Courses
            //        .Include(x => x.Sections)
            //        .Include(x => x.Reviews)
            //        .AsSplitQuery().ToList();
            //}

            #endregion

            #region inner join 
            //using(var _context = new AppDbContext())
            //{

            //// Query Syntax
            //var courses = (from c in _context.Courses.AsNoTracking()
            //               join s in _context.Sections.AsNoTracking()
            //               on c.Id equals s.CourseId
            //               select new
            //               {
            //                   c.CourseName,
            //                   DataRange = s.DateRange.ToString(),
            //                   TimeSlot = s.TimeSlot.ToString(),
            //               }).ToList();

            //// method syntax
            //var Course = _context.Courses.AsNoTracking()
            //    .Join(_context.Sections.AsNoTracking(),
            //        c => c.Id,
            //        s => s.CourseId,
            //        (c, s) => new
            //        {
            //            c.CourseName,
            //            DataRange = s.DateRange.ToString(),
            //            TimeSlot = s.TimeSlot.ToString(),
            //        }
            //    ).ToList();

            //  }
            #endregion

            #region Left Join
            //using (var _context = new AppDbContext())
            //{
            //var OfficeOccupanyQuerySytax = 
            //   ( from o in _context.Offices.AsNoTracking()
            //    join i in _context.Instructors.AsNoTracking()
            //    on o.Id equals i.OfficeId into officeVacancy
            //    from ov in officeVacancy.DefaultIfEmpty()
            //    select new
            //    {
            //        officeID = o.Id,
            //        Name = o.OfficeName,
            //        Location = o.OfficeLocation,
            //        Instructor = ov != null ? ov.FName : "<<Empty>>"
            //    }).ToList();


            //var OfficeOccupanyMethoSytax = _context.Offices.AsNoTracking()
            //    .GroupJoin(_context.Instructors.AsNoTracking(),
            //    o => o.Id,
            //    i => i.OfficeId,
            //    (Office , Instructor) => new {Office, Instructor})
            //    .SelectMany(
            //    (ov) => ov.Instructor.DefaultIfEmpty(),
            //    (ov, Instructor) => new 
            //    {
            //        officeID = ov.Office.Id,
            //        Name = ov.Office.OfficeName,
            //        Location = ov.Office.OfficeLocation,
            //        Instructor = Instructor != null ? Instructor.FName : "<<Empty>>",
            //    }).ToList();
            //  }
            #endregion

            #region Call Stored Pocdures
            //using (var _context = new AppDbContext()) 
            //{
            //    var sections = _context.SectionWithDetails
            //        .FromSql($"Exec dbo.sp_GetSectionDetails {1} ").ToList();
            //    foreach (var section in sections)
            //        Console.WriteLine(section);

            //}
            #endregion

            Console.WriteLine("______________________________________");
            Console.WriteLine("Welcome In Code Academy");
            Console.WriteLine("______________________________________");
            Console.WriteLine();
           

            while (true) {
               
                Console.WriteLine();
                Console.WriteLine("1. Retrieve All Students: ");
                Console.WriteLine("2. Retrieve All Students Is Intern: ");
                Console.WriteLine("3. Search Users by Name: ");
                Console.WriteLine("4. Sorting Students based on graduation year: ");
                Console.WriteLine("5. Number of Particpants: ");
                Console.WriteLine("6. The average graduation year for Individual participants: ");
                Console.WriteLine("7. Retrieve All Students Particpant in Specific Section: ");
                Console.WriteLine("8. Participants with Sections");
                Console.Write("Choose an option: ");

                char choice = char.Parse(Console.ReadLine());
                switch (choice) 
                {
                    case '1':
                        RetrieveAllStudents();
                        break;
                    case '2':
                        RetrieveAllStudentsIsIntern();
                        break;
                    case '3':
                        SearchUsersbyName();
                            break;
                    case '4':
                        SortingStudentsBasedOnGraduationYear();
                        break;
                    case '5':
                        NumberOfParticpants();
                        break;
                    case '6':
                        averageGraduationYearforIndividualParticipants();
                        break;
                    case '7':
                        RetrieveAllStudentsParticpantinSpecificSection();
                        break;
                    case '8':
                        ParticipantsWithSections();
                        break;
                    
                }

            }
        }

        private static void ParticipantsWithSections()
        {
            using (var _context = new AppDbContext()) 
            {
                var ParticipantsWithSections = _context.Particpants.AsNoTracking()
                    .Join(_context.Enrollments.AsNoTracking(),
                    p => p.Id,
                    e => e.ParticpantId,
                    (p,e) => new {p ,e}).Join(_context.Sections.AsNoTracking(),
                    pe => pe.e.SectionId,
                    s => s.Id,
                    (pe , s) => new
                    {
                        Name = pe.p.FName + " " + pe.p.LName,
                        SectionName = s.SectionName
                    }).ToList();

                ParticipantsWithSections.Print("Participants With Sections");
            }
        }

        private static void RetrieveAllStudentsParticpantinSpecificSection()
        {
            Console.Write("Enter a Section Name: ");
            var sectionName = (Console.ReadLine());

            using (var _context = new AppDbContext()) 
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

        private static void averageGraduationYearforIndividualParticipants()
        {
            using (var _context = new AppDbContext()) 
            {
                var averageGraduationYear = _context.Set<Individual>()
                    .Average(x=>x.YearOfGraduation);

                Console.WriteLine($"The average graduation year for Individual participants is: {(int)averageGraduationYear}");
            }
        }

        private static void NumberOfParticpants()
        {
            using (var _context = new AppDbContext()) 
            {
                var numOfParticpants = _context.Particpants.Count();
                Console.WriteLine($"The number of Participents is : {numOfParticpants}");
            }
        }
        
        #region Query Data Using LINQ

        private static void SortingStudentsBasedOnGraduationYear()
        {
            using (var _context = new AppDbContext()) {
                var allStudents = _context.Set<Individual>()
                    .OrderBy(x => x.YearOfGraduation).ToList();
                allStudents.Print("Sorting Students Based On Graduation Year");
            }
            
        }

        private static void SearchUsersbyName()
        {
            Console.Write("Enter the First Name: ");
            var FName = Console.ReadLine();
            Console.Write("Enter the Last Name: ");
            var LName = Console.ReadLine();

            using (var _context = new AppDbContext())
            {

                var studentName = _context.Set<Individual>()
                    .Where(x => x.FName == FName && x.LName == LName)
                    .FirstOrDefault();
               
                if(studentName is null)
                    Console.WriteLine("The student is not exist");
                else
                    Console.WriteLine($"{studentName.Id}  ( {studentName.FName}, {studentName.LName} ) " +
                        $"Graduted on ({studentName.YearOfGraduation}) From {studentName.University} " +
                        $"({(studentName.IsIntern ? "Internship" : "")})");

            }
        }

        private static void RetrieveAllStudentsIsIntern()
        {
            using (var _context = new AppDbContext()) 
            {
                var studentIsIntern = _context.Set<Individual>()
                    .Where(x => x.IsIntern)
                    .ToList();

                studentIsIntern.Print("All Student Is Intern");
            }
        }

        private static void RetrieveAllStudents()
        {
            using (var _context = new AppDbContext())
            {
                var allStudent = _context.Set<Individual>().ToList();
                allStudent.Print("All Students");
            }
        }
        
        #endregion

    }
}
