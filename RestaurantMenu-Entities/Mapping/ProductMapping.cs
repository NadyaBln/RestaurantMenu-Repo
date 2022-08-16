using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantMenu_Entities.Entities;

namespace RestaurantMenu_Entities.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product", "dbo");
            builder.HasKey(x => x.ProductId);
            //builder.HasOne(p => p.CategoryId).WithOne().HasForeignKey<Category>(p => p.CategoryId);
        }
    }
}
