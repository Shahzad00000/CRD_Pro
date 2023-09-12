using CRD_Pro.Models;
using Microsoft.EntityFrameworkCore;

namespace CRD_Pro.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
