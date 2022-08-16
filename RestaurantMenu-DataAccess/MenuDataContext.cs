using Microsoft.EntityFrameworkCore;
using RestaurantMenu_Entities.Entities;
using RestaurantMenu_Entities.Mapping;

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
        public DbSet<Guest> Guest { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Allergen> Allergen { get; set; }

        //mapping is discribing connection btw category and product
        //set mapping for product and category
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //mapping settings for category and product
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
            modelBuilder.ApplyConfiguration(new GuestMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new AllergenMapping());
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
