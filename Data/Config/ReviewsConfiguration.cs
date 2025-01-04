using CodeAcademy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy.Data.Config
{
    public class ReviewsConfiguration : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(EntityTypeBuilder<Reviews> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Id)
                .ValueGeneratedNever();

            builder.Property(x => x.Feedback)
                .HasColumnType("VARCHAR")
                .HasMaxLength(250);

        }
    }
}
