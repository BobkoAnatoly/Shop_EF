using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Application.EntityTypeConfiguration
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasData(new Position {Id=1, Name = "Аналитик", Salary = 1000 },
                new Position {Id=2, Name = "Водитель" },
                new Position {Id=3, Name = "Грузчик" });

            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Salary).IsRequired();

        }
    }
}
