using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> Categoties { get; set; } 
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductVariation> ProductVariations { get; set; }
        public DbSet<Season> Seasons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                    .HasKey(pc => new { pc.CategoryId, pc.ProductId });
            modelBuilder.Entity<ProductCategory>()
                    .HasOne(p => p.Product)
                    .WithMany(pc => pc.ProductCategories)
                    .HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<ProductCategory>()
                    .HasOne(p => p.Category)
                    .WithMany(pc => pc.ProductCategories)
                    .HasForeignKey(c => c.CategoryId);

           
        }
    }
}
