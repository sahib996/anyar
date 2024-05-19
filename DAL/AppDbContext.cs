using Anyar_1_.Models;
using Microsoft.EntityFrameworkCore;

namespace Anyar_1_.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt): base(opt) 
        {
            
        }
        public DbSet<Position> Positions { get; set; }
         public DbSet<Team> Teams { get; set; }
    }
}
