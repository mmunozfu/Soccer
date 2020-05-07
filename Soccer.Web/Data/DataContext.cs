using Microsoft.EntityFrameworkCore;
using Soccer.Web.Data.Entity;

namespace Soccer.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<TeamEntity> Teams { get; set; }
    }
}
