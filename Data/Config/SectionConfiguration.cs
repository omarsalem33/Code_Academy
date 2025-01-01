using CodeAcademy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.Data.Config
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(255).IsRequired();

            builder.HasOne(x => x.Instructor)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.InsId)
                .IsRequired(false);

            builder.HasOne(x => x.Course)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.CourseId)
                .IsRequired();

            builder.HasOne(x => x.Schedule)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.ScheduleId)
                .IsRequired();

            builder.OwnsOne(x => x.TimeSlot, ts =>
            {
                ts.Property(p => p.StartTime).HasColumnType("time").HasColumnName("StartTime");
                ts.Property(p => p.EndTime).HasColumnType("time").HasColumnName("EndTime");
            });

            builder.HasData(LoadSections());

            builder.ToTable("Sections");
        }

        private static List<Section> LoadSections()
        {
            return new List<Section>
            {
                new Section { Id = 1, Name = "S_MA1", CourseId = 1, InsId = 1, ScheduleId = 1, TimeSlot = new TimeSlot { StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(9, 30, 0) } },
                new Section { Id = 2, Name = "S_MA2", CourseId = 1, InsId = 2, ScheduleId = 3, TimeSlot = new TimeSlot { StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(11, 30, 0) } },
                new Section { Id = 3, Name = "S_PH1", CourseId = 2, InsId = 1, ScheduleId = 4, TimeSlot = new TimeSlot { StartTime = new TimeSpan(12, 0, 0), EndTime = new TimeSpan(13, 30, 0) } },
                new Section { Id = 4, Name = "S_PH2", CourseId = 2, InsId = 3, ScheduleId = 1, TimeSlot = new TimeSlot { StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(15, 30, 0) } },
                new Section { Id = 5, Name = "S_CH1", CourseId = 3, InsId = 2, ScheduleId = 1, TimeSlot = new TimeSlot { StartTime = new TimeSpan(16, 0, 0), EndTime = new TimeSpan(17, 30, 0) } },
                new Section { Id = 6, Name = "S_CH2", CourseId = 3, InsId = 3, ScheduleId = 2, TimeSlot = new TimeSlot { StartTime = new TimeSpan(8, 30, 0), EndTime = new TimeSpan(10, 0, 0) } },
                new Section { Id = 7, Name = "S_BI1", CourseId = 4, InsId = 4, ScheduleId = 3, TimeSlot = new TimeSlot { StartTime = new TimeSpan(11, 0, 0), EndTime = new TimeSpan(12, 30, 0) } },
                new Section { Id = 8, Name = "S_BI2", CourseId = 4, InsId = 5, ScheduleId = 4, TimeSlot = new TimeSlot { StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(14, 30, 0) } },
                new Section { Id = 9, Name = "S_CS1", CourseId = 5, InsId = 4, ScheduleId = 4, TimeSlot = new TimeSlot { StartTime = new TimeSpan(15, 0, 0), EndTime = new TimeSpan(16, 30, 0) } },
                new Section { Id = 10, Name = "S_CS2", CourseId = 5, InsId = 5, ScheduleId = 3, TimeSlot = new TimeSlot { StartTime = new TimeSpan(17, 0, 0), EndTime = new TimeSpan(18, 30, 0) } },
                new Section { Id = 11, Name = "S_CS3", CourseId = 5, InsId = 4, ScheduleId = 5, TimeSlot = new TimeSlot { StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(10, 30, 0) } }
            };
        }
    }
}
