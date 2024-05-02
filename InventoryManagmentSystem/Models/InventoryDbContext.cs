using Microsoft.EntityFrameworkCore;

namespace InventoryManagmentSystem.Models
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Chair", Price = 10.00m, Description = "Chair" },
                new Product { Id = 2, Name = "Table", Price = 20.00m, Description = "Table" }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Inventory;Trusted_Connection=True;MultipleActiveResultSets=true\r\n");
        }
    }
}
