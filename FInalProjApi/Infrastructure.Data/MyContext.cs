using Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MyContext : DbContext
    {
        private DbContextOptions<MyContext> _options;
        
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            _options = options;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Problem> Problems { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<History> Histories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}