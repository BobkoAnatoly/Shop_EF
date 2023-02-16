using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop_Application.Models;

namespace Shop.Persistence.EntityTypeConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Id).IsUnique();

            builder.HasData(new Category { Id = 1, Name = "Смартфоны" },
                new Category {Id = 2, Name = "Наушники" },
                new Category {Id=3, Name = "Фитнес браслеты" });
        }
    }
}
