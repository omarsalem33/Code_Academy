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

            builder.HasData(LoadSections());

            builder.ToTable("Sections");
        }

        private static List<Section> LoadSections()
        {
            return new List<Section>
            {
                new Section { Id = 1, Name = "S_MA1"},
                new Section { Id = 2, Name = "S_MA2"},
                new Section { Id = 3, Name = "S_PH1"},
                new Section { Id = 4, Name = "S_PH2"},
                new Section { Id = 5, Name = "S_CH1"},
                new Section { Id = 6, Name = "S_CH2"},
                new Section { Id = 7, Name = "S_BI1"},
                new Section { Id = 8, Name = "S_BI2"},
                new Section { Id = 9, Name = "S_CS1"},
                new Section { Id = 10, Name = "S_CS2"},
                new Section { Id = 11, Name = "S_CS3"}
            };
        }
    }
}
