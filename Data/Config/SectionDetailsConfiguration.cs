using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CodeAcademy.Entities;

namespace CodeAcademy.Data.Config
{
    public class SectionDetailsConfiguration : IEntityTypeConfiguration<SectionWithDetails>
    {
        public void Configure(EntityTypeBuilder<SectionWithDetails> builder)
        {
            builder.HasNoKey();
        }

    }
}
