﻿// <auto-generated />
using System;
using CodeAcademy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeAcademy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodeAcademy.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Mathmatics",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Physics",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Chemistry",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Biology",
                            Price = 1200m
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "CS-50",
                            Price = 3000m
                        });
                });

            modelBuilder.Entity("CodeAcademy.Entities.Enrollment", b =>
                {
                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("SectionId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("CodeAcademy.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique()
                        .HasFilter("[OfficeId] IS NOT NULL");

                    b.ToTable("Instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Ahmed",
                            LName = "Abdullah",
                            OfficeId = 1
                        },
                        new
                        {
                            Id = 2,
                            FName = "Yasmeen",
                            LName = "Yasmeen",
                            OfficeId = 2
                        },
                        new
                        {
                            Id = 3,
                            FName = "Khalid",
                            LName = "Hassan",
                            OfficeId = 3
                        },
                        new
                        {
                            Id = 4,
                            FName = "Nadia",
                            LName = "Ali",
                            OfficeId = 4
                        },
                        new
                        {
                            Id = 5,
                            FName = "Ahmed",
                            LName = "Abdullah",
                            OfficeId = 5
                        });
                });

            modelBuilder.Entity("CodeAcademy.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OfficeLocation = "building A",
                            OfficeName = "Off_05"
                        },
                        new
                        {
                            Id = 2,
                            OfficeLocation = "building B",
                            OfficeName = "Off_12"
                        },
                        new
                        {
                            Id = 3,
                            OfficeLocation = "Adminstration",
                            OfficeName = "Off_32"
                        },
                        new
                        {
                            Id = 4,
                            OfficeLocation = "IT Department",
                            OfficeName = "Off_44"
                        },
                        new
                        {
                            Id = 5,
                            OfficeLocation = "IT Department",
                            OfficeName = "Off_43"
                        });
                });

            modelBuilder.Entity("CodeAcademy.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("FRI")
                        .HasColumnType("bit");

                    b.Property<bool>("MON")
                        .HasColumnType("bit");

                    b.Property<bool>("SAT")
                        .HasColumnType("bit");

                    b.Property<bool>("SUN")
                        .HasColumnType("bit");

                    b.Property<bool>("THU")
                        .HasColumnType("bit");

                    b.Property<bool>("TUE")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<bool>("WED")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Schedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Daily",
                            WED = true
                        },
                        new
                        {
                            Id = 2,
                            FRI = false,
                            MON = false,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "DayAfterDay",
                            WED = false
                        },
                        new
                        {
                            Id = 3,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Twice-a-Week",
                            WED = true
                        },
                        new
                        {
                            Id = 4,
                            FRI = true,
                            MON = false,
                            SAT = true,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Weekend",
                            WED = false
                        },
                        new
                        {
                            Id = 5,
                            FRI = true,
                            MON = true,
                            SAT = true,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Compact",
                            WED = true
                        });
                });

            modelBuilder.Entity("CodeAcademy.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InsId");

                    b.ToTable("Sections", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            InsId = 1,
                            Name = "S_MA1"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            InsId = 2,
                            Name = "S_MA2"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            InsId = 1,
                            Name = "S_PH1"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            InsId = 3,
                            Name = "S_PH2"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            InsId = 2,
                            Name = "S_CH1"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 3,
                            InsId = 3,
                            Name = "S_CH2"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 4,
                            InsId = 4,
                            Name = "S_BI1"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 4,
                            InsId = 5,
                            Name = "S_BI2"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 5,
                            InsId = 4,
                            Name = "S_CS1"
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 5,
                            InsId = 5,
                            Name = "S_CS2"
                        },
                        new
                        {
                            Id = 11,
                            CourseId = 5,
                            InsId = 4,
                            Name = "S_CS3"
                        });
                });

            modelBuilder.Entity("CodeAcademy.Entities.SectionSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SectionId");

                    b.ToTable("SectionSchedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndTime = new TimeSpan(0, 10, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 1,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 2,
                            StartTime = new TimeSpan(0, 14, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 3,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            EndTime = new TimeSpan(0, 12, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 4,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 1,
                            SectionId = 5,
                            StartTime = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            EndTime = new TimeSpan(0, 10, 0, 0, 0),
                            ScheduleId = 2,
                            SectionId = 6,
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 7,
                            StartTime = new TimeSpan(0, 11, 0, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            EndTime = new TimeSpan(0, 14, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 8,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            ScheduleId = 4,
                            SectionId = 9,
                            StartTime = new TimeSpan(0, 16, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            EndTime = new TimeSpan(0, 15, 0, 0, 0),
                            ScheduleId = 3,
                            SectionId = 10,
                            StartTime = new TimeSpan(0, 12, 0, 0, 0)
                        },
                        new
                        {
                            Id = 11,
                            EndTime = new TimeSpan(0, 11, 0, 0, 0),
                            ScheduleId = 5,
                            SectionId = 11,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("CodeAcademy.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Fatima",
                            LName = "Ali"
                        },
                        new
                        {
                            Id = 2,
                            FName = "Noor",
                            LName = "Saleh"
                        },
                        new
                        {
                            Id = 3,
                            FName = "Omar",
                            LName = "Youssef"
                        },
                        new
                        {
                            Id = 4,
                            FName = "Huda",
                            LName = "Ahmed"
                        },
                        new
                        {
                            Id = 5,
                            FName = "Amira",
                            LName = "Tariq"
                        },
                        new
                        {
                            Id = 6,
                            FName = "Zainab",
                            LName = "Ismail"
                        },
                        new
                        {
                            Id = 7,
                            FName = "Yousef",
                            LName = "Farid"
                        },
                        new
                        {
                            Id = 8,
                            FName = "Layla",
                            LName = "Mustafa"
                        },
                        new
                        {
                            Id = 9,
                            FName = "Mohammed",
                            LName = "Adel"
                        },
                        new
                        {
                            Id = 10,
                            FName = "Samira",
                            LName = "Nabil"
                        });
                });

            modelBuilder.Entity("ScheduleSection", b =>
                {
                    b.Property<int>("SchedulesId")
                        .HasColumnType("int");

                    b.Property<int>("SectionsId")
                        .HasColumnType("int");

                    b.HasKey("SchedulesId", "SectionsId");

                    b.HasIndex("SectionsId");

                    b.ToTable("ScheduleSection");
                });

            modelBuilder.Entity("CodeAcademy.Entities.Enrollment", b =>
                {
                    b.HasOne("CodeAcademy.Entities.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("CodeAcademy.Entities.Instructor", b =>
                {
                    b.HasOne("CodeAcademy.Entities.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("CodeAcademy.Entities.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("CodeAcademy.Entities.Section", b =>
                {
                    b.HasOne("CodeAcademy.Entities.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy.Entities.Instructor", "Instructor")
                        .WithMany("Sections")
                        .HasForeignKey("InsId");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("CodeAcademy.Entities.SectionSchedule", b =>
                {
                    b.HasOne("CodeAcademy.Entities.Schedule", null)
                        .WithMany("SectionSchedules")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy.Entities.Section", null)
                        .WithMany("SectionSchedules")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ScheduleSection", b =>
                {
                    b.HasOne("CodeAcademy.Entities.Schedule", null)
                        .WithMany()
                        .HasForeignKey("SchedulesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeAcademy.Entities.Section", null)
                        .WithMany()
                        .HasForeignKey("SectionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeAcademy.Entities.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("CodeAcademy.Entities.Instructor", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("CodeAcademy.Entities.Office", b =>
                {
                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("CodeAcademy.Entities.Schedule", b =>
                {
                    b.Navigation("SectionSchedules");
                });

            modelBuilder.Entity("CodeAcademy.Entities.Section", b =>
                {
                    b.Navigation("SectionSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}
