using API_NET.Domain;
using Microsoft.EntityFrameworkCore;

namespace API_NET.Infraestuture
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().Property(x => x.Description)
                .HasMaxLength(500)
                .IsRequired(false);
            builder.Entity<Product>()
                .Property(x => x.Name)
                .HasMaxLength(120)
                .IsRequired();
            builder.Entity<Product>()
                .Property(x => x.Code)
                .HasMaxLength(20)
                .IsRequired();
            builder.Entity<Category>()
                .ToTable("Categories");
        }
    }
}
