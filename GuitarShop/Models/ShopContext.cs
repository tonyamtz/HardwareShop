using Microsoft.EntityFrameworkCore;

namespace HardwareShop.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Safety and Security" },
                new Category { CategoryID = 2, Name = "Fire Safety" },
                new Category { CategoryID = 3, Name = "Doors and Locks" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1, 
                    CategoryID = 1,
                    Code = "fire",
                    Name = "Fire Extenguisher",
                    Price = (decimal)29.00
                },
                new Product
                {
                    ProductID = 2,
                    CategoryID = 1,
                    Code = "fire",
                    Name = "Carbon Monoxide Detector",
                    Price = (decimal)19.00
                },
                new Product
                {
                    ProductID = 3,
                    CategoryID = 1,
                    Code = "safe",
                    Name = "MasterLock Combination Lock",
                    Price = (decimal)7.00
                },
                new Product
                {
                    ProductID = 4,
                    CategoryID = 1,
                    Code = "safe",
                    Name = "Gun Safe",
                    Price = (decimal)489.99
                },
                new Product
                {
                    ProductID = 5,
                    CategoryID = 1,
                    Code = "door",
                    Name = "Electronic Deadbolt Doorlock",
                    Price = (decimal)299.00
                },
                new Product
                {
                    ProductID = 6,
                    CategoryID = 1,
                    Code = "door",
                    Name = "Knob and Cylinder Deadbolt",
                    Price = (decimal)15.00
                },
                new Product
                {
                    ProductID = 7,
                    CategoryID = 2,
                    Code = "safe",
                    Name = "Outdoor Floodlight",
                    Price = (decimal)79.99
                },
                new Product
                {
                    ProductID = 8,
                    CategoryID = 2,
                    Code = "safe",
                    Name = "Window Alarm",
                    Price = (decimal)49.99
                },
                new Product
                {
                    ProductID = 9,
                    CategoryID = 3,
                    Code = "safe",
                    Name = "Asbestos Test Kit",
                    Price = (decimal)19.99
                },
                new Product
                {
                    ProductID = 10,
                    CategoryID = 3,
                    Code = "fire",
                    Name = "Ionization Smoke Detector",
                    Price = (decimal)19.99
                }
            );
        }
    }
}