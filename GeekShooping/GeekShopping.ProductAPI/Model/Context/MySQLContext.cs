using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                   Id = 2,
                   Nome = "Name2",
                   Price = new decimal(79.9),
                   Description = "Description",
                   ImageUrl = "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg",
                   CategoryName = "T-Shirt",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Nome = "Name3",
                Price = new decimal(999.9),
                Description = "Description3",
                ImageUrl = "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg",
                CategoryName = "Action figure",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Nome = "Name4",
                Price = new decimal(99.9),
                Description = "Description4",
                ImageUrl = "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg",
                CategoryName = "Picture",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Nome = "Name5",
                Price = new decimal(79.25),
                Description = "Description5",
                ImageUrl = "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg",
                CategoryName = "T-Shirt",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Nome = "Name6",
                Price = new decimal(129.9),
                Description = "Description6",
                ImageUrl = "https://github.com/Edvilson/microservices-dotnet6/blob/main/GeekShooping/ShoppingImages/6_spacex.jpg",
                CategoryName = "Pants",
            });
        }
    }
}
