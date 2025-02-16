﻿using CodeAcademy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CodeAcademy.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Particpant> Particpants { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<MultipleChoiceQuiz> MultipleChoiceQuizes { get; set; }
        public DbSet<TrueAndFalseQuiz> TrueAndFalseQuizes { get; set; }
        public DbSet<Review> Reviews { get; set; } 
        public DbSet<SectionWithDetails> SectionWithDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = config.GetSection("ConnectionStrings:DefaultConnection").Value;

            optionsBuilder.UseSqlServer(connectionString)// add log on console
               // .LogTo(Console.WriteLine,Microsoft.Extensions.Logging.LogLevel.Information)
                ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
