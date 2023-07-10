using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataContext
{
   public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }

        public DbSet<Director> Directors { get; set; }
    }
}