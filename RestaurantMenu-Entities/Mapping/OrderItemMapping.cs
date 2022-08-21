using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantMenu_Entities.Entities;

namespace RestaurantMenu_Entities.Mapping
{
    public class OrderItemMapping : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItem", "dbo");
            builder.HasKey(x => x.OrderItemId);
            //builder.HasMany(x => x.Product);
            //builder.HasOne(x => x.Order);
        }
    }
}
