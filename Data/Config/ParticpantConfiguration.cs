using CodeAcademy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy.Data.Config
{
    public class ParticpantConfiguration : IEntityTypeConfiguration<Particpant>
    {
        public void Configure(EntityTypeBuilder<Particpant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.FName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50).IsRequired();

            builder.Property(x => x.LName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50).IsRequired();

            builder.HasMany(x => x.Sections)
                .WithMany(x => x.Participants)
                .UsingEntity<Enrollment>();

            builder.HasDiscriminator<string>("ParticipantType")
                .HasValue<Individual>("INDV")
                .HasValue<Coporate>("COPR");

            builder.Property("ParticipantType")
               .HasColumnType("VARCHAR")
               .HasMaxLength(4);

            builder.ToTable("Particpants");
        }
    }
}
