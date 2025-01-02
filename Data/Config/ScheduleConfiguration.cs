using CodeAcademy.Entities;
using CodeAcademy.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy.Data.Config
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            //builder.Property(x => x.Title)
            //    .HasColumnType("VARCHAR")
            //    .HasMaxLength(50).IsRequired();

            builder.Property(x => x.Title)
                   .HasConversion(
                        x => x.ToString(),
                        x => (ScheduleEnum)Enum.Parse(typeof(ScheduleEnum), x)
                   );

            builder.ToTable("Schedules");
        }
    }
}
