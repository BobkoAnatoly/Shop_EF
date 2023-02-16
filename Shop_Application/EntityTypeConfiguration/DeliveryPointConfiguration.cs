using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop_Application.Models;
namespace Shop_Application.EntityTypeConfiguration
{
    public class DeliveryPointConfiguration : IEntityTypeConfiguration<DeliveryPoint>
    {
        public void Configure(EntityTypeBuilder<DeliveryPoint> builder)
        {
            //Каскадное удаление
            builder.HasMany(x => x.Employees)
                .WithOne(x => x.DeliveryPoint)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
