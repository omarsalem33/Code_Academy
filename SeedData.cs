﻿using CodeAcademy.Entities;
using CodeAcademy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy
{
    public static class SeedData
    {

        // Method to load data for Offices
        public static List<Office> LoadOffices() => new()
        {
            new Office { Id = 1, OfficeName = "Off_05", OfficeLocation = "Building A" },
            new Office { Id = 2, OfficeName = "Off_12", OfficeLocation = "Building B" },
            new Office { Id = 3, OfficeName = "Off_32", OfficeLocation = "Administration" },
            new Office { Id = 4, OfficeName = "Off_44", OfficeLocation = "IT Department" },
            new Office { Id = 5, OfficeName = "Off_43", OfficeLocation = "IT Department" }
        };

        // Method to load data for Courses
        public static List<Course> LoadCourses() => new()
        {
           new Course { Id = 1, CourseName = "Mathematics", Price = 1000.00m },
           new Course { Id = 2, CourseName = "Physics", Price = 2000.00m },
           new Course { Id = 3, CourseName = "Chemistry", Price = 1500.00m },
           new Course { Id = 4, CourseName = "Biology", Price = 1200.00m },
           new Course { Id = 5, CourseName = "CS-50", Price = 3000.00m }
        };

        // Method to load data for Schedules
        public static List<Schedule> LoadSchedules() => new()
        {
          new Schedule { Id = 1, Title = ScheduleEnum.Daily, SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = false, SAT = false },
          new Schedule { Id = 2, Title = ScheduleEnum.DayAfterDay, SUN = true, MON = false, TUE = true, WED = false, THU = true, FRI = false, SAT = false },
          new Schedule { Id = 3, Title = ScheduleEnum.TwiceAWeek, SUN = false, MON = true, TUE = false, WED = true, THU = false, FRI = false, SAT = false },
          new Schedule { Id = 4, Title = ScheduleEnum.Weekend, SUN = false, MON = false, TUE = false, WED = false, THU = false, FRI = true, SAT = true },
          new Schedule { Id = 5, Title = ScheduleEnum.Compact, SUN = true, MON = true, TUE = true, WED = true, THU = true, FRI = true, SAT = true }
        };

        // Method to load data for Instructors
        public static List<Instructor> LoadInstructors() => new()
        {
            new Instructor { Id = 1, FName = "Ahmed", LName = "Abdullah", OfficeId = 1 },
            new Instructor { Id = 2, FName = "Yasmeen", LName = "Mohammed", OfficeId = 2 },
            new Instructor { Id = 3, FName = "Khalid", LName = "Hassan", OfficeId = 3 },
            new Instructor { Id = 4, FName = "Nadia", LName = "Ali", OfficeId = 4 },
            new Instructor { Id = 5, FName = "Omar", LName = "Ibrahim", OfficeId = 5 }
        };

        // Method to load data for Sections
        public static List<Section> LoadSections() => new()
        {
            new Section { Id = 1, SectionName = "S_MA1", CourseId = 1, InstructorId = 1, ScheduleId = 1, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") } },
            new Section { Id = 2, SectionName = "S_MA2", CourseId = 1, InstructorId = 2, ScheduleId = 3, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("14:00:00"), EndTime = TimeSpan.Parse("18:00:00") } },
            new Section { Id = 3, SectionName = "S_PH1", CourseId = 2, InstructorId = 1, ScheduleId = 4, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("15:00:00") } },
            new Section { Id = 4, SectionName = "S_PH2", CourseId = 2, InstructorId = 3, ScheduleId = 1, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("12:00:00") } },
            new Section { Id = 5, SectionName = "S_CH1", CourseId = 3, InstructorId = 2, ScheduleId = 1, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00") } },
            new Section { Id = 6, SectionName = "S_CH2", CourseId = 3, InstructorId = 3, ScheduleId = 2, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") } },
            new Section { Id = 7, SectionName = "S_BI1", CourseId = 4, InstructorId = 4, ScheduleId = 3, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("11:00:00"), EndTime = TimeSpan.Parse("14:00:00") } },
            new Section { Id = 8, SectionName = "S_BI2", CourseId = 4, InstructorId = 5, ScheduleId = 4, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("10:00:00"), EndTime = TimeSpan.Parse("14:00:00") } },
            new Section { Id = 9, SectionName = "S_CS1", CourseId = 5, InstructorId = 4, ScheduleId = 4, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("16:00:00"), EndTime = TimeSpan.Parse("18:00:00") } },
            new Section { Id = 10, SectionName = "S_CS2", CourseId = 5, InstructorId = 5, ScheduleId = 3, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("12:00:00"), EndTime = TimeSpan.Parse("15:00:00") } },
            new Section { Id = 11, SectionName = "S_CS3", CourseId = 5, InstructorId = 4, ScheduleId = 5, TimeSlot = new TimeSlot { StartTime = TimeSpan.Parse("09:00:00"), EndTime = TimeSpan.Parse("11:00:00") } }
        };

        // Method to load data for Corporates
        public static List<Coporate> LoadCorporates() => new()
        {
            new Coporate { Id = 2, FName = "Noor", LName = "Saleh", CompanyName = "ABC", JobTitle = "Developer" },
            new Coporate { Id = 4, FName = "Huda", LName = "Ahmed", CompanyName = "ABC", JobTitle = "QA" },
            new Coporate { Id = 7, FName = "Yousef", LName = "Farid", CompanyName = "EFG", JobTitle = "Developer" },
            new Coporate { Id = 8, FName = "Layla", LName = "Mustafa", CompanyName = "EFG", JobTitle = "QA" }
        };

        // Method to load data for Individuals
        public static List<Individual> LoadIndividuals() => new()
        {
            new Individual { Id = 1, FName = "Fatima", LName = "Ali",University = "XYZ", YearOfGraduation = 2024, IsIntern = false },
            new Individual { Id = 3, FName = "Omar", LName = "Youssef", University = "POQ", YearOfGraduation = 2023, IsIntern = true },
            new Individual { Id = 5, FName = "Amira", LName = "Tariq", University = "POQ", YearOfGraduation = 2025, IsIntern = false },
            new Individual { Id = 6, FName = "Zainab", LName = "Ismail", University = "POQ", YearOfGraduation = 2023, IsIntern = true },
            new Individual { Id = 9, FName = "Mohammed", LName = "Adel", University = "XYZ", YearOfGraduation = 2024, IsIntern = false },
            new Individual { Id = 10, FName = "Samira", LName = "Nabil", University = "XYZ", YearOfGraduation = 2024, IsIntern = false }
        };

        // Method to load data for Enrollments
        public static List<Enrollment> LoadEnrollments() => new()
        {
            new Enrollment { SectionId = 1, ParticpantId = 1 },
            new Enrollment { SectionId = 2, ParticpantId = 2 },
            new Enrollment { SectionId = 3, ParticpantId = 3 },
            new Enrollment { SectionId = 4, ParticpantId = 4 },
            new Enrollment { SectionId = 5, ParticpantId = 5 },
            new Enrollment { SectionId = 6, ParticpantId = 6 },
            new Enrollment { SectionId = 7, ParticpantId = 7 },
            new Enrollment { SectionId = 8, ParticpantId = 8 },
            new Enrollment { SectionId = 9, ParticpantId = 9 },
            new Enrollment { SectionId = 10, ParticpantId = 10 }
        };

        // Method to load data for MultipleChoiceQuiz
        public static List<MultipleChoiceQuiz> LoadMultipleChoiceQuizzes() => new()
        {
           new () { Id = 3, Title = "Chemistry Basics", CourseId = 3, OptionA = "H2O", OptionB = "CO2", OptionC = "O2", OptionD = "H2SO4", CorrectAnswer = 'A' },
           new () { Id = 4, Title = "Biology Terminology", CourseId =  4, OptionA = "Cell", OptionB = "Atom", OptionC = "Tissue", OptionD = "Organ", CorrectAnswer = 'C' }
        };

        // Method to load data for TrueAndFalseQuiz
        public static List<TrueAndFalseQuiz> LoadTrueAndFalseQuizzes() => new()
        {
            new () { Id = 3, Title = "What is the first element on the periodic table?", CourseId = 3, CorrectAnswer = true },
            new () { Id = 4, Title = "Physics Laws - True or False", CourseId = 2, CorrectAnswer = false },
        };
    }
}
