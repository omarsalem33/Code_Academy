using CodeAcademy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeAcademy.Data.Config
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasKey(x => x.Id);  
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.UseTpcMappingStrategy();
        }
    }
}
