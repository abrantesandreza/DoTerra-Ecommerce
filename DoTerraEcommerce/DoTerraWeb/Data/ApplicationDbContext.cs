using Microsoft.EntityFrameworkCore;

namespace DoTerraWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
    }
}
