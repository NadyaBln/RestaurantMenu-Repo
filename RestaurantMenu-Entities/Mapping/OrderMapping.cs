using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantMenu_Entities.Entities;

namespace RestaurantMenu_Entities.Mapping
{
    public class OrderMapping : IEntityTypeConfiguration<Orders>
    {
        //object 'Order' = table Order
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.ToTable("Orders", "dbo");
            builder.HasKey(x => x.OrderId);
        }
    }
}
