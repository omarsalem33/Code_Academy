using CodeAcademy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy.Data.Config
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.SectionName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(255).IsRequired();

            builder.HasOne(x => x.Instructor)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.InstructorId)
                .IsRequired(false);

            builder.HasOne(x => x.Course)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.CourseId)
                .IsRequired();

            builder.OwnsOne(x => x.TimeSlot, ts =>
            {
                ts.Property(p => p.StartTime).HasColumnType("time").HasColumnName("StartTime");
                ts.Property(p => p.EndTime).HasColumnType("time").HasColumnName("EndTime");
            });

            builder.OwnsOne(x => x.DateRange, ts =>
            {
                ts.Property(p => p.StartDate).HasColumnType("DATE").HasColumnName("StartDate").IsRequired();
                ts.Property(p => p.EndDate).HasColumnType("DATE").HasColumnName("EndDate").IsRequired();
            });

            builder.HasOne(x => x.Schedule)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.ScheduleId)
                .IsRequired();

            builder.ToTable("Sections");
        }
    }
}
