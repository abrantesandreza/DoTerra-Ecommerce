using DoTerraWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DoTerraWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Óleos Essenciais", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Acessórios", DisplayOrder = 2 }
                );
        }
    }
}
