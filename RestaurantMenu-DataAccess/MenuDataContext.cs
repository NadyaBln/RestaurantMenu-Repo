using Microsoft.EntityFrameworkCore;
using RestaurantMenu_Entities.Entities;

namespace RestaurantMenu_DataAccess
{
    //context = DataBase
    public class MenuDataContext : DbContext
    {
        //db set = table
        //specify data type we use in each table 
        //in table Category we use object Category
        public DbSet<Product> Product { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Allergen> Allergen { get; set; }

        //mapping is discribing connection btw category and product
        //set mapping for product and category
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////mapping settings for category and product
            //modelBuilder.ApplyConfiguration(new ProductMapping());
            //modelBuilder.ApplyConfiguration(new OrderMapping());
            //modelBuilder.ApplyConfiguration(new OrderItemMapping());
            //modelBuilder.ApplyConfiguration(new GuestMapping());
            //modelBuilder.ApplyConfiguration(new CategoryMapping());
            //modelBuilder.ApplyConfiguration(new AllergenMapping());

            modelBuilder.Entity<Allergen>().ToTable("Allergen", "dbo");
            modelBuilder.Entity<Allergen>().HasKey(x => x.AllergenId);

            modelBuilder.Entity<Category>().ToTable("Category", "dbo");
            modelBuilder.Entity<Category>().HasKey(x => x.CategoryId);

            modelBuilder.Entity<Guest>().ToTable("Guest", "dbo");
            modelBuilder.Entity<Guest>().HasKey(x => x.GuestId);

            modelBuilder.Entity<OrderItem>().ToTable("OrderItem", "dbo");
            modelBuilder.Entity<OrderItem>().HasKey(x => x.OrderItemId);
            ////1 to many
            //modelBuilder.Entity<OrderItem>()
            //     .HasOne(e => e.Products)
            //     .WithMany(e => e.Items)
            //     .HasForeignKey(e => e.ProductId);

            // modelBuilder.Entity<OrderItem>()
            //.HasMany(e => e.Products);
            //.WithOne(e => e.OrderItem);

            modelBuilder.Entity<OrderItem>()
                .HasMany<Product>(e => e.Products)
                .WithMany(e => e.Items);

            modelBuilder.Entity<Orders>().ToTable("Orders", "dbo");
            modelBuilder.Entity<Orders>().HasKey(x => x.OrderId);
            //modelBuilder.Entity<Orders>().HasOne(e => e.Guest);
            //modelBuilder.Entity<Orders>()
            //    .HasOne(e => e.OrderItem)
            //    .WithOne(e => e.Order)
            //    .HasForeignKey<Orders>(e => e.OrderItemId);

            modelBuilder.Entity<Product>().ToTable("Product", "dbo");
            modelBuilder.Entity<Product>()
                .HasKey(x => x.ProductId);
            //modelBuilder.Entity<Product>()
            //    .HasOne<OrderItem>(e=>e.Items)




            base.OnModelCreating(modelBuilder);
        }

        //use Sql server with this connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string to DB
            optionsBuilder.UseSqlServer(@"Server=.;Database=RestaurantMenuDB;Trusted_Connection=True;");
        }
    }
}
