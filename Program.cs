using CodeAcademy.Data;
using CodeAcademy.Entities;
using CodeAcademy.PartcipantOperation;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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


            var context = new AppDbContext();

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
                        var students = IndividualOperations.RetrieveAllStudents(context);
                        if (students.IsNullOrEmpty())
                            Console.WriteLine("There are no registered students");
                        else
                        {
                            Console.WriteLine("All Students:");
                            foreach (var student in students)
                                Console.WriteLine(student);
                        }
                        break;

                    case '2':
                        var studentIsIntern = IndividualOperations.RetrieveAllStudentsIsIntern(context);
                        if(studentIsIntern.IsNullOrEmpty())
                            Console.WriteLine("There are no Students Intern");
                        else
                        {
                            Console.WriteLine("Students is Intern:");
                            foreach (var student in studentIsIntern)
                                Console.WriteLine(student);
                        }
                        break;

                    case '3':
                        Console.Write("Enter the First Name: ");
                        var FName = Console.ReadLine();
                        Console.Write("Enter the Last Name: ");
                        var LName = Console.ReadLine();

                        var studentByName = IndividualOperations.SearchUsersbyName(context , FName , LName);
                        if(studentByName == null)
                            Console.WriteLine("No student found with the specified name.");
                        else
                        {
                            Console.Write("Student is found: ");
                            Console.WriteLine(studentByName);
                        }
                        break;
                    
                    case '4':
                        var StudentsBaseOnGraduatedyears = IndividualOperations.SortingStudentsBasedOnGraduationYear(context);
                        if(StudentsBaseOnGraduatedyears is null)
                            Console.WriteLine("There are no registered students");
                        else
                        {
                            Console.WriteLine("All Students Based On Graduation Years:");
                            foreach (var student in StudentsBaseOnGraduatedyears)
                                Console.WriteLine(student);
                        }
                        break;
                    
                    case '5':
                        var number = PartcipantOperations.NumberOfParticpants(context);
                        Console.WriteLine(number);
                        break;
                    
                    case '6':
                        Console.WriteLine(IndividualOperations.averageGraduationYearforIndividualParticipants(context));
                        break;
                    
                    case '7':
                         IndividualOperations.RetrieveAllStudentsParticpantinSpecificSection(context);
                     break;
                    
                    case '8':
                        IndividualOperations.ParticipantsWithSections();
                        break;
                    
                }
            }
        }
    }
}
