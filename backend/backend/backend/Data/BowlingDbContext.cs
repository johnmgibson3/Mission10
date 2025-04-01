using Microsoft.EntityFrameworkCore;

namespace backend.Data;
public class BowlingDbContext : DbContext
{
    public BowlingDbContext(DbContextOptions<BowlingDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Bowlers> Bowlers { get; set; }
}