using Evira.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Evira.Data.DbContext
{
    public class EviraDbContext: IdentityDbContext<User>
    {
        public EviraDbContext(DbContextOptions<EviraDbContext> options): base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<Eviras> Eviras { get; set; }
    }
}
