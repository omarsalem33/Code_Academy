using CodeAcademy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy.Data.Config
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Feedback)
                .HasColumnType("VARCHAR")
                .HasMaxLength(250);

            builder.HasOne(x => x.Course)
                .WithMany(x => x.Reviews)
                .HasForeignKey(x => x.CourseId)
                .IsRequired();

            builder.Property(x => x.CreatedAt).IsRequired();
            builder.ToTable("Reviews");

        }
    }
}
